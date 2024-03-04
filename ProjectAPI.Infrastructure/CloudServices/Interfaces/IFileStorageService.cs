using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAPI.Infrastructure.CloudServices.Interfaces
{
    public interface IFileStorageService
    {
        void UploadFile(byte[] bytes, string fileName);
    }
}