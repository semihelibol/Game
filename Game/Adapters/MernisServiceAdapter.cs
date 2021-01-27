using GameDemo.Abstract;
using GameDemo.Entities;
using ServiceReference;
using System;

namespace GameDemo.Adapters
{
    public class MernisServiceAdapter : IPlayerCheckService

    {

        public bool CheckIfRealPlayer(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(
                    new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(player.TcNumber), player.FirstName.ToUpper(), player.LastName.ToUpper(), player.DateOfBirth.Year)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
