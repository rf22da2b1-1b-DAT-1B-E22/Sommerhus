using SommerhusLib.MockData;
using SommerhusLib.model;

namespace SonnerhusApp.services
{
    public class SommerhusRepositoryService : ISommerhusRepositoryService
    {
        public List<Sommerhus> GetAll()
        {
            return new List<Sommerhus> ( SommerhusMockData.GetSommerhuse() );   
        }
    }
}
