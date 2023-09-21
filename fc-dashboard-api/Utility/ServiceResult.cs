using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fc_dashboard_api.Utility
{
    public class ServiceResult<T>: IServiceResult
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
        public T data { get; set; }

        public ServiceResult()
        {
            Status = 404;
            Message = "No Records";
        }

        public void SetSuccess()
        {
            Status = 200;
            Message = "Success";
        }

        public void SetSuccess(T data)
        {
            this.data = data;
            Status = 200;
            Message = "Success";
        }

        public void SetFailure(string failureMessage)
        {
            Status = 417;
            Message = failureMessage;
        }

        public void SetAccessDenied()
        {
            Status = 703;
            Message = "Access Denied";
        }

        public void SetStatus(bool isSuccess)
        {
            if (isSuccess)
            {
                SetSuccess();
            }
            else
                SetFailure("");
        }

        public void SetInvalidModel()
        {
            Status = 422;
            Message = "Invalid Model";
        }


        public void AddError(string error)
        {
            if (Errors == null)
            {
                Errors = new List<string>();
            }
            Errors.Add(error);
        }

        public bool IsSuccess()
        {
            return Status == 200 ? true : false;
        }

    }

    public interface IServiceResult
    {
    }
}
