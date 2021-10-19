using System.Collections.Generic;

namespace LeakGas.Api.Wrapper
{
    public class Response
    {


        public Response(IEnumerable<string> errors)
        {
            Success = false;
            Errors = errors;
        }       
        public Response(object data)
        {
            Success = true;
            Data = data;
        }

        public IEnumerable<string> Errors { get; set; }
        public bool Success { get; set; }
        public object Data { get; set; }
    }    
    public class Response<T>
    {

        public IEnumerable<string> Errors { get; set; }
        public bool Success { get; set; }
        public T Data { get; set; }
    }

}
