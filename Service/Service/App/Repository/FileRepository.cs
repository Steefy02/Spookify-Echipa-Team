using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Service.App.Repository
{
    class FileRepository
    {
        private List<Entity.File> fileList = new List<Entity.File>();

        public List<Entity.File> GetFileList()
        {  
            return fileList; 
        }
        
        public void AddFile(Entity.File file)
        { 
            fileList.Add(file);
        }



        public void DeleteFile(int fileId)
        {
            foreach (Entity.File file in fileList)
                if(file.GetFileId() == fileId)
                    fileList.Remove(file);
            
        }

        public void UpdateFile(Entity.File givenFile , int fileId)
        {
            for (int i = 0; i < fileList.Count; i++)
                if (fileList[i].GetFileId() == fileId)
                    fileList[i] = givenFile;

        }

        public Entity.File GetFileById(int fileId)
        {
            for (int i = 0; i < fileList.Count; i++)
                if (fileList[i].GetFileId() == fileId)
                    return fileList[i];

            return null;
        }


    }
}
