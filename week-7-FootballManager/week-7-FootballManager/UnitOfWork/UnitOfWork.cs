using week_7_FootballManager.SeviceAbstracts;

namespace week_7_FootballManager.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public ITeamService TeamService { get; set; }
        public IFootballerService FootballerService { get; set; }
        public ICoachService CoachService { get; set; }
        public IManagementPositionService ManagementPositionService { get; set; }
        public IManagerService ManagerService { get; set; }
        public ITacticService TacticService { get; set; }
        public IPositionService PositionService { get; set; }
        public INationalTeamService NationalTeamService { get; set; }
    }
}
