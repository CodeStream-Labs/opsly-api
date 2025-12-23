namespace OpslyApi.DTOs
{
    public class ApiResponse<T> where T : class
    {
        public bool Success { get; private set; } = false;
        public T Data { get; private set; }
        public Dictionary<string, string> Notifications { get; private set; } = [];

        private void IsSuccess()
        {
            if (Data is not null && Notifications.Count == 0)
            {
                Success = true;
                return;
            }

            Success = false;
            Data = null;
        }

        public void AddErrorMessage(string message)
        {
            Notifications.Add("ERROR", message);
            IsSuccess();
        }

        public void AddResult(T result)
        {
            Data = result;
            IsSuccess();
        }
    }
}