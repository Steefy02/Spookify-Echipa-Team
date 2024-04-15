using System.Collections.Generic;



namespace Service.App.Repository
{
    public class FileRepository
    {
        private List<Entity.File> fileList = new List<Entity.File>();

        public FileRepository(List<Entity.File> fileList)
        {
            this.fileList = fileList;
        }

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
                if (file.GetFileId() == fileId)
                    fileList.Remove(file);

        }

        public void UpdateFile(Entity.File givenFile, int fileId)
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
