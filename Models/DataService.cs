namespace BandsMVC.Models
{
    class DataService
    {
        List<Band> bands = new List<Band>
        {
            new Band { Id = 1, Name = "Rammstein", Description = "German synthpop"},
            new Band { Id = 32, Name = "Infected Mushroom", Description = "Psytrance"},
            new Band { Id = 64, Name = "One Direction", Description = "Pop"},
            new Band { Id = 87, Name = "Coca Carola", Description = "Punk"}
        };

        public Band[] GetAllBands()
        {
            return bands.ToArray();
        }

        public Band? GetBandById(int id)
        {
            return bands.FirstOrDefault(a => a.Id == id);
        }
    }
}