using System;
using System.IO;
using System.Text.RegularExpressions;

namespace kurs
{
    class MediaFile
    {
                                        //1---2-3- 4-5-6-7- 8----------  9-
                                        //20130226_171632L0_Description (43)
        static Regex rxName = new Regex(@"^(\d{4})(\d{2})(\d{2})_(\d{2})(\d{2})(\d{2})(.*)_(.+?)(?: \((\d+)\))?$");

        public MediaFile(string fullname)
        {
            Reparse(fullname);
        }
        
        void Reparse(string fullname)
        {
            FullName = fullname;
            Name = Path.GetFileName(fullname);
            FileTime = File.GetLastWriteTime(fullname);

            string extless = Path.GetFileNameWithoutExtension(fullname);
            Match match = rxName.Match(extless);
            if (!match.Success)
            {
                ValidName = false;
                return;
            }
            ValidName = true;

            Func<int, string> rxStr = (idx => match.Groups[idx].Value);
            Func<int, int> rxNum = (idx => { int r = 0; int.TryParse(rxStr(idx), out r); return r; });

            Date = new DateTime(rxNum(1), rxNum(2), rxNum(3), rxNum(4), rxNum(5), rxNum(6));
            Label = rxStr(7);
            Desc = rxStr(8);
            Index = rxNum(9);
        }

        public bool ValidName { get; private set; }

        public string   FullName  { get; private set; }
        public string   Name { get; set; }
        public DateTime Date;
        public DateTime FileTime  { get; private set; }
        public string   Desc;
        public string   Label;
        public int      Index;
    
        private string BuildNewName()
        {
            string IndexStr = (Index == 0) ? "" : (" (" + Index.ToString() + ")");
            return Path.GetDirectoryName(FullName) + "\\" +
                Date.ToString("yyyyMMdd_HHmmss") + Label + "_" +
                Desc + IndexStr + Path.GetExtension(FullName);
        }

        public void DoRename(LogForm log, ref bool WereErrors)
        {
            log.Log("Обработка файла <" + FullName + ">");
            string name_ideal = BuildNewName();
            if(name_ideal != FullName)
            {
                string nname = name_ideal;
                while(nname != FullName && File.Exists(nname))
                {
                    Index = Index + 1;
                    nname = BuildNewName();
                }
                if (nname != name_ideal)
                {
                    log.Log("Файл <" + name_ideal + "> уже существует, будет добавлен индекс.");
                    WereErrors = true;
                }
                if (nname == FullName)
                {
                    log.Log("Не удалось сбросить индекс: Все меньшие индексы заняты");
                }
                else
                {
                    log.Log("Новое имя: <" + nname + ">");
                    try
                    {
                        File.Move(FullName, nname);
                        FullName = nname;
                    }
                    catch
                    {
                        log.Log("Ошибка: не удалось переименовать файл!");
                        WereErrors = true;
                    }
                    Reparse(FullName);
                }
            }
            else
            {
                log.Log("Переименование не требуется");
            }
            log.Log("");
        }
    }

}
