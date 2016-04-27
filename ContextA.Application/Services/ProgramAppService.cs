namespace ContextA.Application.Services
{
    public class ProgramAppService
    {
        public string HelloWorld()
        {
            return "Hello World";
        }

        public string HelloContextB()
        {
            //var client = new ContextBService.ProductServiceClient();
            //var result = client.GetData(0);
            //return result;
            return "Hello Context B"; //TODO: Retornar valor do serviço do WCF
        }
    }
}
