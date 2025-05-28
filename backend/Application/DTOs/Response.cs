namespace backend.Application.DTOs
{
    public class Response<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public string ErrorMessage { get; set; }
        public string Text { get; set; }

        public static Response<T> SuccessResponse(T data)
        {
            return new Response<T>
            {
                Success = true,
                Data = data,
                ErrorMessage = null,
                Text = "Operação realizada com sucesso."
            };
        }

        public static Response<T> ErrorResponse(string errorMessage)
        {
            return new Response<T>
            {
                Success = false,
                Data = default,
                ErrorMessage = errorMessage,
                Text = "Erro durante a operação."
            };
        }
    }
}
