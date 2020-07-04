using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace CaseItauJogoDaVelha.Application.Response
{
    public class ResultResponse
    {
        [JsonProperty("status")]
        public bool Result { get; set; }

        [JsonProperty("data")]
        public object Data { get; set; }

        [JsonProperty("error")]
        public IEnumerable<string> Errors { get; set; }

        public static ResultResponse CreateError(params string[] code)
        {
            return new ResultResponse
            {
                Result = false,
                Errors = code.ToList()
            };
        }

        public static ResultResponse CreateSuccess()
        {
            return new ResultResponse
            {
                Result = true,
                Errors = new List<string>()
            };
        }

        public static ResultResponse CreateSuccess(object data)
        {
            return new ResultResponse
            {
                Result = true,
                Errors = new List<string>(),
                Data = data
            };
        }
    }
}
