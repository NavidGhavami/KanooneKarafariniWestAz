using _0_Framework.Domain;

namespace EntrepreneurManagement.Domain.EntrepreneurServices.EntrepreneurCafe
{
    public class EntrepreneurCafe : EntityBase
    {
        public string CafeName { get; private set; }
        public string CafeCity { get; private set; }
        public string CafeManager { get; private set; }
        public string CafeLeader { get; private set; }
        public string CafeManagerMobile { get; private set; }
        public string CafeLeaderMobile { get; private set; }


        public EntrepreneurCafe(string cafeName, string cafeCity, string cafeManager, string cafeLeader, string cafeManagerMobile, string cafeLeaderMobile)
        {
            CafeName = cafeName;
            CafeCity = cafeCity;
            CafeManager = cafeManager;
            CafeLeader = cafeLeader;
            CafeManagerMobile = cafeManagerMobile;
            CafeLeaderMobile = cafeLeaderMobile;
        }

        public void Edit(string cafeName, string cafeCity, string cafeManager, string cafeLeader, string cafeManagerMobile, string cafeLeaderMobile)
        {
            CafeName = cafeName;
            CafeCity = cafeCity;
            CafeManager = cafeManager;
            CafeLeader = cafeLeader;
            CafeManagerMobile = cafeManagerMobile;
            CafeLeaderMobile = cafeLeaderMobile;
        }
    }
}
