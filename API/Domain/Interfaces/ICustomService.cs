using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICustomService
    {
        Task<T> GetAsync<T>(string endpoint);

        Task<T> DeleteAsync<T>(string endpoint);

        Task<T> PostAsync<T>(string endpoint, object request) where T : class;
    }
}