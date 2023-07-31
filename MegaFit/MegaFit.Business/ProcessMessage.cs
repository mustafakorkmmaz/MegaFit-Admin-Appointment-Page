using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.Business
{
    public class ProcessMessage
    {
        private const string DefaultSuccessMessage = "İşlem başarılı";
        private const string DefaultFailureMessage = "İşlem başarısız";

        //
        public bool IsSuccess { get; private set; }
        public string Message { get; private set; }

        // Factory Pattern -> nesne üretici, basma kalıp şekilde nesne üretmek.
        public static ProcessMessage Success()
        {
            return Success(DefaultSuccessMessage);
        }
        public static ProcessMessage Success(string message)
        {
            return new ProcessMessage
            {
                IsSuccess = true,
                Message = message
            };
        }
        public static ProcessMessage Failure()
        {
            return Failure(DefaultFailureMessage);
        }
        public static ProcessMessage Failure(string message)
        {
            return new ProcessMessage
            {
                IsSuccess = false,
                Message = message
            };
        }

    }
}
