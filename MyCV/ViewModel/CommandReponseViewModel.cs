namespace MyCV.ViewModel
{
    public class CommandReponseViewModel<T> where T : class
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public T Data { get; set; }
    }
}
