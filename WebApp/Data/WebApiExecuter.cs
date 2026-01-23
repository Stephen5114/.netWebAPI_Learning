namespace WebApp.Data
{
    public class WebApiExecuter : IWebApiExecuter
    {
        private readonly IHttpClientFactory httpClientFactory;
        private const string apiName = "ShirtsApi";
        public WebApiExecuter(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<T?> InvokeGet<T>(string relativeUrl)
        {
            var httpClient = httpClientFactory.CreateClient(apiName);
            return await httpClient.GetFromJsonAsync<T>(relativeUrl);
        }

        public async Task<T?> InvokePost<T>(string relativeUrl, T obj)
        {
            var httpClient = httpClientFactory.CreateClient(apiName);
            var reponse = await httpClient.PostAsJsonAsync(relativeUrl, obj);
            reponse.EnsureSuccessStatusCode();
            return await reponse.Content.ReadFromJsonAsync<T>();
        }
    }
}
