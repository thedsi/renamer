using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs
{
    class RenameVar
    {
        //data parameter here is assumed not to be NoAction data
        public delegate void FixNameFn(MediaFile mf, RenameVarData data);

        private RenameVar(string name, RenameVarData.ActType allowedActions, FixNameFn f)
        {
            Name = name;
            AllowedActions = allowedActions;
            fixname = f;
        }

        public string Name    { get; private set; }
        public RenameVarData.ActType AllowedActions { get; private set; }

        const RenameVarData.ActType OnlySet = RenameVarData.ActType.Set;
        const RenameVarData.ActType ChangeAll =
            RenameVarData.ActType.Set |
            RenameVarData.ActType.Decrease |
            RenameVarData.ActType.Increase |
            RenameVarData.ActType.SetFileTime;
        const RenameVarData.ActType ZeroOut = RenameVarData.ActType.ZeroOut;


        public void Process(MediaFile mf, RenameVarData d)
        {
            if (!d.IsNoAction)
            {
                fixname(mf, d);
            }
        }

        private FixNameFn fixname;

        static public RenameVar[] All = 
        {
            new RenameVar("Год"     , ChangeAll, (x,d)=>{ x.Date = x.Date.AddYears(d.CalcDelta(x.Date.Year, x.FileTime.Year       ));}),
            new RenameVar("Месяц"   , ChangeAll, (x,d)=>{ x.Date = x.Date.AddMonths(d.CalcDelta(x.Date.Month, x.FileTime.Month    ));}),
            new RenameVar("День"    , ChangeAll, (x,d)=>{ x.Date = x.Date.AddDays(d.CalcDelta(x.Date.Day, x.FileTime.Day          ));}),
            new RenameVar("Час"     , ChangeAll, (x,d)=>{ x.Date = x.Date.AddHours(d.CalcDelta(x.Date.Hour, x.FileTime.Hour       ));}),
            new RenameVar("Минута"  , ChangeAll, (x,d)=>{ x.Date = x.Date.AddMinutes(d.CalcDelta(x.Date.Minute, x.FileTime.Minute ));}),
            new RenameVar("Секунда" , ChangeAll, (x,d)=>{ x.Date = x.Date.AddSeconds(d.CalcDelta(x.Date.Second, x.FileTime.Second ));}),
            new RenameVar("Метка"   , OnlySet  , (x,d)=>{ x.Label = d.ActionString; }),
            new RenameVar("Описание", OnlySet  , (x,d)=>{ x.Desc = d.ActionString; }),
            new RenameVar("Индекс",   ZeroOut  , (x,d)=>{ x.Index = 0; }),


        };

        
    }

    class RenameVarData
    {
        public RenameVarData(RenameVar r)
        {
            renamevar = r;
            Actions = new List<Act>();
            Actions.Add(new Act("Не менять", ActType.NoAction));
            if(r.AllowedActions.HasFlag(ActType.Decrease))
                Actions.Add(new Act("Уменьшить на", ActType.Decrease));

            if(r.AllowedActions.HasFlag(ActType.Set))
                Actions.Add(new Act("Установить в", ActType.Set));

            if(r.AllowedActions.HasFlag(ActType.Increase))
                Actions.Add(new Act("Увеличить на", ActType.Increase));

            if(r.AllowedActions.HasFlag(ActType.SetFileTime))
                Actions.Add(new Act("Установить равным времени файла", ActType.SetFileTime));

            if (r.AllowedActions.HasFlag(ActType.ZeroOut))
                Actions.Add(new Act("Обнулить", ActType.ZeroOut));

            ActionIndex = 0;
            ActionString = "";
        }
        public enum ActType
        {
            NoAction    = 0,
            Set         = 1,
            Increase    = 2,
            Decrease    = 4,
            SetFileTime = 8,
            ZeroOut     = 16
        }

        

        public struct Act
        {
            public readonly string  Name;
            public readonly ActType Action;

            public Act(string name, ActType action)
            {
                Name = name;
                Action = action;
            }
        }

        public int CalcDelta(int OldValue, int FileValue)
        {
            switch(CurAction)
            {
                case ActType.Set:       return ActionInt - OldValue;
                case ActType.Increase:  return ActionInt;
                case ActType.Decrease:  return -ActionInt;
                case ActType.SetFileTime: return FileValue - OldValue;
            }
            return 0;
        }

        public bool IsNoAction
        {
            get
            {
                return CurAction == ActType.NoAction;
            }
        }

        public ActType CurAction
        {
            get
            {
                return Actions[ActionIndex].Action;
            }
        }

        public bool NeedActionString
        {
            get
            {
                switch(CurAction)
                {
                    case ActType.Set:
                    case ActType.Increase:
                    case ActType.Decrease:
                        return true;
                }
                return false;
            }
            
        }

        public int ActionIndex;
        public string ActionString;
        public int ActionInt { get { return int.Parse(ActionString); }}

        public List<Act> Actions { get; private set; }

        private RenameVar renamevar;
    }

    
}
