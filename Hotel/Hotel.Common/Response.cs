namespace Hotel.Common
{
    public class Response<T>
    {
        private bool isSuccess;
        public bool IsSuccess
        {
            get
            {
                return isSuccess;
            }
            set
            {
                isSuccess = value;
                if (isSuccess)
                    Message = string.Empty;
            }
        }
        public string Message { get; set; }

        private T data;
        public T Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
                if (data != null)
                {
                    IsSuccess = true;
                }
            }
        }
        public bool IsValid { get; set; } = true;

        public Response()
        {
        }

        public Response(T data)
        {
            Data = data;
        }

        public Response(bool success, string message = null)
        {
            Message = message;
        }

        public Response(T data, bool isSuccess, string message = null)
        {
            IsSuccess = isSuccess;
            Message = message;
            Data = data;
            IsValid = true;
        }
    }
}
