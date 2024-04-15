using Service.App.Entity;
using Service.App.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.App.Service
{
    public class FileService
    {
        private Repository.FileRepository fileRepository;
        private Entity.User user;
        private StreamCountService streamCountService;

        public FileService(Repository.FileRepository fileRepository, Entity.User user, StreamCountService streamCountService)
        {
            this.fileRepository = fileRepository;
            this.user = user;
            this.streamCountService = streamCountService;
        }

        public void SaveFile(Entity.File file)
        {

        }

        public void PlaySong(int fileId)
        {

        }

        public Entity.File DownloadSong(int fileId) 
        {
        
            return null;
        }
        public void UploadSong(Entity.File file) 
        {
        
        }

        public Entity.File GetFileById(int fileId) 
        {
            return null; 
        }

        public void DeleteSong(int fileId) 
        {
        
        }

    }
}
