using SommerhusLib.model;

namespace SonnerhusApp.services
{
    public interface ISommerhusRepositoryService
    {
        public List<Sommerhus> GetAll();
        public Sommerhus GetById(int id);
        public Sommerhus Create(Sommerhus hus);
        public Sommerhus Delete(int id);
        public Sommerhus Update(int id, Sommerhus hus);

    }
}
