using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.App.Entity
{
    public class File {
        private string file_path;
        private string owner_name;
        private int file_id;

        public File(string file_path, string owner_name, int file_id)
        {
            this.file_path = file_path;
            this.owner_name = owner_name;
            this.file_id = file_id;
        }

        public string GetFilePath()
        {
            return this.file_path;
        }


        public string GetOwnerName()
        {
            return this.owner_name;
        }

        public int GetFileId()
        {
            return this.file_id;
        }

        public void SetFilePath(string file_path)
        {
            this.file_path=file_path;
        }


        public void SetOwnerName(string owner_name)
        {
            this.owner_name = owner_name;
        }

      



    }

}
