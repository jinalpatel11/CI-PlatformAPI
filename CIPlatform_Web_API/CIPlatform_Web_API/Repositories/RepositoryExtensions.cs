namespace CIPlatform_Web_API.Repositories
{
    using CIPlatform_Web_API.Infrastructure;

    public static class RepositoryExtensions
    {
        public static void Map(this User dbUser, User user)
        {
            dbUser.Name = user.Name;
            dbUser.FirstName = user.FirstName;
        }

        public static void Map(this CmspagesTable dbCmspagesTable, CmspagesTable CmspagesTable)
        {
            dbCmspagesTable.PageDescription = CmspagesTable.PageDescription;
        }

        public static void Map(this CommentTable dbCommentTable, CommentTable CommentTable)
        {
            dbCommentTable.Id = CommentTable.Id;
        }

        public static void Map(this ContactUsTable dbContactUsTable, ContactUsTable ContactUsTable)
        {
            dbContactUsTable.Id = ContactUsTable.Id;
        }

        public static void Map(this DocumentTable dbDocumentTable, DocumentTable DocumentTable)
        {
            dbDocumentTable.Id = DocumentTable.Id;
        }

        public static void Map(this Mission dbMissionTable, Mission MissionTable)
        {
            dbMissionTable.Id = MissionTable.Id;
        }

        public static void Map(this Story dbStoryTable, Story StoryTable)
        {
            dbStoryTable.Id = StoryTable.Id;
        }

        public static void Map(this VolunteeringTable dbVolunteeringTable, VolunteeringTable VolunteeringTable)
        {
            dbVolunteeringTable.Id = VolunteeringTable.Id;
        }
    }
}
