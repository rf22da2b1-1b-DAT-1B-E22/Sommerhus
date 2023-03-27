using SommerhusLib.MockData;
using SommerhusLib.model;

namespace SonnerhusApp.services
{
    public class SommerhusRepositoryService : ISommerhusRepositoryService
    {
        public Sommerhus Create(Sommerhus hus)
        {
            throw new NotImplementedException();
        }

        public Sommerhus Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Sommerhus> GetAll()
        {
            return new List<Sommerhus> ( SommerhusMockData.GetSommerhuse() );   
        }

        public Sommerhus GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Sommerhus Update(int id, Sommerhus hus)
        {
            throw new NotImplementedException();
        }
    }
}
