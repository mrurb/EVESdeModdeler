using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EpsynServices.Models.EVEModels
{
    public partial class EvESDEContext : DbContext
    {
        public virtual DbSet<Agent> Agtagents { get; set; }
        public virtual DbSet<Agtagenttypes> Agtagenttypes { get; set; }
        public virtual DbSet<Agtresearchagents> Agtresearchagents { get; set; }
        public virtual DbSet<Certcerts> Certcerts { get; set; }
        public virtual DbSet<Chrancestries> Chrancestries { get; set; }
        public virtual DbSet<Chrattributes> Chrattributes { get; set; }
        public virtual DbSet<Chrbloodlines> Chrbloodlines { get; set; }
        public virtual DbSet<Chrfactions> Chrfactions { get; set; }
        public virtual DbSet<Chrraces> Chrraces { get; set; }
        public virtual DbSet<Crpactivities> Crpactivities { get; set; }
        public virtual DbSet<NPCCorpDivision> Crpnpccorporationdivisions { get; set; }
        public virtual DbSet<Crpnpccorporationresearchfields> Crpnpccorporationresearchfields { get; set; }
        public virtual DbSet<NPCCorporation> Crpnpccorporations { get; set; }
        public virtual DbSet<Crpnpccorporationtrades> Crpnpccorporationtrades { get; set; }
        public virtual DbSet<NPCCorpDivision> Crpnpcdivisions { get; set; }
        public virtual DbSet<Dgmattributecategories> Dgmattributecategories { get; set; }
        public virtual DbSet<Dgmattributetypes> Dgmattributetypes { get; set; }
        public virtual DbSet<Dgmeffects> Dgmeffects { get; set; }
        public virtual DbSet<Dgmexpressions> Dgmexpressions { get; set; }
        public virtual DbSet<Dgmtypeattributes> Dgmtypeattributes { get; set; }
        public virtual DbSet<Dgmtypeeffects> Dgmtypeeffects { get; set; }
        public virtual DbSet<Evegraphics> Evegraphics { get; set; }
        public virtual DbSet<Eveicons> Eveicons { get; set; }
        public virtual DbSet<Eveunits> Eveunits { get; set; }
        public virtual DbSet<Industryactivity> Industryactivity { get; set; }
        public virtual DbSet<Industryblueprints> Industryblueprints { get; set; }
        public virtual DbSet<Invcategories> Invcategories { get; set; }
        public virtual DbSet<Invcontrabandtypes> Invcontrabandtypes { get; set; }
        public virtual DbSet<Invcontroltowerresourcepurposes> Invcontroltowerresourcepurposes { get; set; }
        public virtual DbSet<Invcontroltowerresources> Invcontroltowerresources { get; set; }
        public virtual DbSet<Invflags> Invflags { get; set; }
        public virtual DbSet<Invgroups> Invgroups { get; set; }
        public virtual DbSet<Invitems> Invitems { get; set; }
        public virtual DbSet<Invmarketgroups> Invmarketgroups { get; set; }
        public virtual DbSet<Invmetagroups> Invmetagroups { get; set; }
        public virtual DbSet<Invmetatypes> Invmetatypes { get; set; }
        public virtual DbSet<Invnames> Invnames { get; set; }
        public virtual DbSet<Invpositions> Invpositions { get; set; }
        public virtual DbSet<Invtraits> Invtraits { get; set; }
        public virtual DbSet<Invtypematerials> Invtypematerials { get; set; }
        public virtual DbSet<Invtypereactions> Invtypereactions { get; set; }
        public virtual DbSet<Invtypes> Invtypes { get; set; }
        public virtual DbSet<Invuniquenames> Invuniquenames { get; set; }
        public virtual DbSet<Invvolumes> Invvolumes { get; set; }
        public virtual DbSet<Mapcelestialstatistics> Mapcelestialstatistics { get; set; }
        public virtual DbSet<Mapconstellationjumps> Mapconstellationjumps { get; set; }
        public virtual DbSet<Mapconstellations> Mapconstellations { get; set; }
        public virtual DbSet<Mapdenormalize> Mapdenormalize { get; set; }
        public virtual DbSet<Mapjumps> Mapjumps { get; set; }
        public virtual DbSet<Maplandmarks> Maplandmarks { get; set; }
        public virtual DbSet<Maplocationscenes> Maplocationscenes { get; set; }
        public virtual DbSet<Maplocationwormholeclasses> Maplocationwormholeclasses { get; set; }
        public virtual DbSet<Mapregionjumps> Mapregionjumps { get; set; }
        public virtual DbSet<Mapregions> Mapregions { get; set; }
        public virtual DbSet<Mapsolarsystemjumps> Mapsolarsystemjumps { get; set; }
        public virtual DbSet<Mapsolarsystems> Mapsolarsystems { get; set; }
        public virtual DbSet<Mapuniverse> Mapuniverse { get; set; }
        public virtual DbSet<Planetschematics> Planetschematics { get; set; }
        public virtual DbSet<Planetschematicspinmap> Planetschematicspinmap { get; set; }
        public virtual DbSet<Planetschematicstypemap> Planetschematicstypemap { get; set; }
        public virtual DbSet<Ramactivities> Ramactivities { get; set; }
        public virtual DbSet<Ramassemblylinestations> Ramassemblylinestations { get; set; }
        public virtual DbSet<Ramassemblylinetypedetailpercategory> Ramassemblylinetypedetailpercategory { get; set; }
        public virtual DbSet<Ramassemblylinetypedetailpergroup> Ramassemblylinetypedetailpergroup { get; set; }
        public virtual DbSet<Ramassemblylinetypes> Ramassemblylinetypes { get; set; }
        public virtual DbSet<Raminstallationtypecontents> Raminstallationtypecontents { get; set; }
        public virtual DbSet<Skinlicense> Skinlicense { get; set; }
        public virtual DbSet<Skinmaterials> Skinmaterials { get; set; }
        public virtual DbSet<Skins> Skins { get; set; }
        public virtual DbSet<Staoperations> Staoperations { get; set; }
        public virtual DbSet<Staoperationservices> Staoperationservices { get; set; }
        public virtual DbSet<Staservices> Staservices { get; set; }
        public virtual DbSet<Stastations> Stastations { get; set; }
        public virtual DbSet<Stastationtypes> Stastationtypes { get; set; }
        public virtual DbSet<Translationtables> Translationtables { get; set; }
        public virtual DbSet<Trntranslationcolumns> Trntranslationcolumns { get; set; }
        public virtual DbSet<Trntranslationlanguages> Trntranslationlanguages { get; set; }
        public virtual DbSet<Trntranslations> Trntranslations { get; set; }
        public virtual DbSet<Warcombatzones> Warcombatzones { get; set; }
        public virtual DbSet<Warcombatzonesystems> Warcombatzonesystems { get; set; }

        // Unable to generate entity type for table 'certmasteries'. Please see the warning messages.
        // Unable to generate entity type for table 'certskills'. Please see the warning messages.
        // Unable to generate entity type for table 'industryactivitymaterials'. Please see the warning messages.
        // Unable to generate entity type for table 'industryactivityprobabilities'. Please see the warning messages.
        // Unable to generate entity type for table 'industryactivityproducts'. Please see the warning messages.
        // Unable to generate entity type for table 'industryactivityraces'. Please see the warning messages.
        // Unable to generate entity type for table 'industryactivityskills'. Please see the warning messages.
        // Unable to generate entity type for table 'skinship'. Please see the warning messages.
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agent>(entity =>
            {
                entity.HasKey(e => e.AgentId);

                entity.ToTable("agtagents");

                entity.HasIndex(e => e.CorporationId)
                    .HasName("ix_agtAgents_corporationID");

                entity.HasIndex(e => e.LocationId)
                    .HasName("ix_agtAgents_locationID");

                entity.Property(e => e.AgentId)
                    .HasColumnName("agentID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgentTypeId)
                    .HasColumnName("agentTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorporationId)
                    .HasColumnName("corporationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DivisionId)
                    .HasColumnName("divisionID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsLocator)
                    .HasColumnName("isLocator")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LocationId)
                    .HasColumnName("locationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Quality)
                    .HasColumnName("quality")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Agtagenttypes>(entity =>
            {
                entity.HasKey(e => e.AgentTypeId);

                entity.ToTable("agtagenttypes");

                entity.Property(e => e.AgentTypeId)
                    .HasColumnName("agentTypeID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgentType)
                    .HasColumnName("agentType")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Agtresearchagents>(entity =>
            {
                entity.HasKey(e => new { e.AgentId, e.TypeId });

                entity.ToTable("agtresearchagents");

                entity.HasIndex(e => e.TypeId)
                    .HasName("ix_agtResearchAgents_typeID");

                entity.Property(e => e.AgentId)
                    .HasColumnName("agentID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Certcerts>(entity =>
            {
                entity.HasKey(e => e.CertId);

                entity.ToTable("certcerts");

                entity.Property(e => e.CertId)
                    .HasColumnName("certID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.GroupId)
                    .HasColumnName("groupID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Chrancestries>(entity =>
            {
                entity.HasKey(e => e.AncestryId);

                entity.ToTable("chrancestries");

                entity.Property(e => e.AncestryId)
                    .HasColumnName("ancestryID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AncestryName)
                    .HasColumnName("ancestryName")
                    .HasMaxLength(100);

                entity.Property(e => e.BloodlineId)
                    .HasColumnName("bloodlineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Charisma)
                    .HasColumnName("charisma")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.IconId)
                    .HasColumnName("iconID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Intelligence)
                    .HasColumnName("intelligence")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Memory)
                    .HasColumnName("memory")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Perception)
                    .HasColumnName("perception")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShortDescription)
                    .HasColumnName("shortDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.Willpower)
                    .HasColumnName("willpower")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Chrattributes>(entity =>
            {
                entity.HasKey(e => e.AttributeId);

                entity.ToTable("chrattributes");

                entity.Property(e => e.AttributeId)
                    .HasColumnName("attributeID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttributeName)
                    .HasColumnName("attributeName")
                    .HasMaxLength(100);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.IconId)
                    .HasColumnName("iconID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasMaxLength(500);

                entity.Property(e => e.ShortDescription)
                    .HasColumnName("shortDescription")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Chrbloodlines>(entity =>
            {
                entity.HasKey(e => e.BloodlineId);

                entity.ToTable("chrbloodlines");

                entity.Property(e => e.BloodlineId)
                    .HasColumnName("bloodlineID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BloodlineName)
                    .HasColumnName("bloodlineName")
                    .HasMaxLength(100);

                entity.Property(e => e.Charisma)
                    .HasColumnName("charisma")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorporationId)
                    .HasColumnName("corporationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.FemaleDescription)
                    .HasColumnName("femaleDescription")
                    .HasMaxLength(1000);

                entity.Property(e => e.IconId)
                    .HasColumnName("iconID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Intelligence)
                    .HasColumnName("intelligence")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaleDescription)
                    .HasColumnName("maleDescription")
                    .HasMaxLength(1000);

                entity.Property(e => e.Memory)
                    .HasColumnName("memory")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Perception)
                    .HasColumnName("perception")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RaceId)
                    .HasColumnName("raceID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShipTypeId)
                    .HasColumnName("shipTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShortDescription)
                    .HasColumnName("shortDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.ShortFemaleDescription)
                    .HasColumnName("shortFemaleDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.ShortMaleDescription)
                    .HasColumnName("shortMaleDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.Willpower)
                    .HasColumnName("willpower")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Chrfactions>(entity =>
            {
                entity.HasKey(e => e.FactionId);

                entity.ToTable("chrfactions");

                entity.Property(e => e.FactionId)
                    .HasColumnName("factionID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CorporationId)
                    .HasColumnName("corporationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.FactionName)
                    .HasColumnName("factionName")
                    .HasMaxLength(100);

                entity.Property(e => e.IconId)
                    .HasColumnName("iconID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MilitiaCorporationId)
                    .HasColumnName("militiaCorporationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RaceIds)
                    .HasColumnName("raceIDs")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SizeFactor).HasColumnName("sizeFactor");

                entity.Property(e => e.SolarSystemId)
                    .HasColumnName("solarSystemID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StationCount)
                    .HasColumnName("stationCount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StationSystemCount)
                    .HasColumnName("stationSystemCount")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Chrraces>(entity =>
            {
                entity.HasKey(e => e.RaceId);

                entity.ToTable("chrraces");

                entity.Property(e => e.RaceId)
                    .HasColumnName("raceID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.IconId)
                    .HasColumnName("iconID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RaceName)
                    .HasColumnName("raceName")
                    .HasMaxLength(100);

                entity.Property(e => e.ShortDescription)
                    .HasColumnName("shortDescription")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Crpactivities>(entity =>
            {
                entity.HasKey(e => e.ActivityId);

                entity.ToTable("crpactivities");

                entity.Property(e => e.ActivityId)
                    .HasColumnName("activityID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityName)
                    .HasColumnName("activityName")
                    .HasMaxLength(100);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<NPCCorpDivision>(entity =>
            {
                entity.HasKey(e => new { e.CorporationId, e.DivisionId });

                entity.ToTable("crpnpccorporationdivisions");

                entity.Property(e => e.CorporationId)
                    .HasColumnName("corporationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DivisionId)
                    .HasColumnName("divisionID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Crpnpccorporationresearchfields>(entity =>
            {
                entity.HasKey(e => new { e.SkillId, e.CorporationId });

                entity.ToTable("crpnpccorporationresearchfields");

                entity.Property(e => e.SkillId)
                    .HasColumnName("skillID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorporationId)
                    .HasColumnName("corporationID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NPCCorporation>(entity =>
            {
                entity.HasKey(e => e.CorporationId);

                entity.ToTable("crpnpccorporations");

                entity.Property(e => e.CorporationId)
                    .HasColumnName("corporationID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Border)
                    .HasColumnName("border")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Corridor)
                    .HasColumnName("corridor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(4000);

                entity.Property(e => e.EnemyId)
                    .HasColumnName("enemyID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Extent)
                    .HasColumnName("extent")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FactionId)
                    .HasColumnName("factionID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FriendId)
                    .HasColumnName("friendID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fringe)
                    .HasColumnName("fringe")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Hub)
                    .HasColumnName("hub")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IconId)
                    .HasColumnName("iconID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InitialPrice)
                    .HasColumnName("initialPrice")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvestorId1)
                    .HasColumnName("investorID1")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvestorId2)
                    .HasColumnName("investorID2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvestorId3)
                    .HasColumnName("investorID3")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvestorId4)
                    .HasColumnName("investorID4")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvestorShares1)
                    .HasColumnName("investorShares1")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvestorShares2)
                    .HasColumnName("investorShares2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvestorShares3)
                    .HasColumnName("investorShares3")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvestorShares4)
                    .HasColumnName("investorShares4")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MinSecurity).HasColumnName("minSecurity");

                entity.Property(e => e.PublicShares)
                    .HasColumnName("publicShares")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Scattered)
                    .HasColumnName("scattered")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasColumnType("char(1)");

                entity.Property(e => e.SizeFactor).HasColumnName("sizeFactor");

                entity.Property(e => e.SolarSystemId)
                    .HasColumnName("solarSystemID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StationCount)
                    .HasColumnName("stationCount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StationSystemCount)
                    .HasColumnName("stationSystemCount")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Crpnpccorporationtrades>(entity =>
            {
                entity.HasKey(e => new { e.CorporationId, e.TypeId });

                entity.ToTable("crpnpccorporationtrades");

                entity.Property(e => e.CorporationId)
                    .HasColumnName("corporationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NPCCorpDivision>(entity =>
            {
                entity.HasKey(e => e.DivisionId);

                entity.ToTable("crpnpcdivisions");

                entity.Property(e => e.DivisionId)
                    .HasColumnName("divisionID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.DivisionName)
                    .HasColumnName("divisionName")
                    .HasMaxLength(100);

                entity.Property(e => e.LeaderType)
                    .HasColumnName("leaderType")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Dgmattributecategories>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("dgmattributecategories");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("categoryID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryDescription)
                    .HasColumnName("categoryDescription")
                    .HasMaxLength(200);

                entity.Property(e => e.CategoryName)
                    .HasColumnName("categoryName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Dgmattributetypes>(entity =>
            {
                entity.HasKey(e => e.AttributeId);

                entity.ToTable("dgmattributetypes");

                entity.Property(e => e.AttributeId)
                    .HasColumnName("attributeID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttributeName)
                    .HasColumnName("attributeName")
                    .HasMaxLength(100);

                entity.Property(e => e.CategoryId)
                    .HasColumnName("categoryID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DefaultValue).HasColumnName("defaultValue");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("displayName")
                    .HasMaxLength(150);

                entity.Property(e => e.HighIsGood)
                    .HasColumnName("highIsGood")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.IconId)
                    .HasColumnName("iconID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Published)
                    .HasColumnName("published")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Stackable)
                    .HasColumnName("stackable")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.UnitId)
                    .HasColumnName("unitID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Dgmeffects>(entity =>
            {
                entity.HasKey(e => e.EffectId);

                entity.ToTable("dgmeffects");

                entity.Property(e => e.EffectId)
                    .HasColumnName("effectID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.DisallowAutoRepeat)
                    .HasColumnName("disallowAutoRepeat")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.DischargeAttributeId)
                    .HasColumnName("dischargeAttributeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DisplayName)
                    .HasColumnName("displayName")
                    .HasMaxLength(100);

                entity.Property(e => e.Distribution)
                    .HasColumnName("distribution")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DurationAttributeId)
                    .HasColumnName("durationAttributeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EffectCategory)
                    .HasColumnName("effectCategory")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EffectName)
                    .HasColumnName("effectName")
                    .HasMaxLength(400);

                entity.Property(e => e.ElectronicChance)
                    .HasColumnName("electronicChance")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.FalloffAttributeId)
                    .HasColumnName("falloffAttributeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FittingUsageChanceAttributeId)
                    .HasColumnName("fittingUsageChanceAttributeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasMaxLength(60);

                entity.Property(e => e.IconId)
                    .HasColumnName("iconID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsAssistance)
                    .HasColumnName("isAssistance")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.IsOffensive)
                    .HasColumnName("isOffensive")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.IsWarpSafe)
                    .HasColumnName("isWarpSafe")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.ModifierInfo)
                    .HasColumnName("modifierInfo")
                    .HasColumnType("text");

                entity.Property(e => e.NpcActivationChanceAttributeId)
                    .HasColumnName("npcActivationChanceAttributeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NpcUsageChanceAttributeId)
                    .HasColumnName("npcUsageChanceAttributeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PostExpression)
                    .HasColumnName("postExpression")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PreExpression)
                    .HasColumnName("preExpression")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PropulsionChance)
                    .HasColumnName("propulsionChance")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Published)
                    .HasColumnName("published")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.RangeAttributeId)
                    .HasColumnName("rangeAttributeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RangeChance)
                    .HasColumnName("rangeChance")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.SfxName)
                    .HasColumnName("sfxName")
                    .HasMaxLength(20);

                entity.Property(e => e.TrackingSpeedAttributeId)
                    .HasColumnName("trackingSpeedAttributeID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Dgmexpressions>(entity =>
            {
                entity.HasKey(e => e.ExpressionId);

                entity.ToTable("dgmexpressions");

                entity.Property(e => e.ExpressionId)
                    .HasColumnName("expressionID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Arg1)
                    .HasColumnName("arg1")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Arg2)
                    .HasColumnName("arg2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.ExpressionAttributeId)
                    .HasColumnName("expressionAttributeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExpressionGroupId)
                    .HasColumnName("expressionGroupID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExpressionName)
                    .HasColumnName("expressionName")
                    .HasMaxLength(500);

                entity.Property(e => e.ExpressionTypeId)
                    .HasColumnName("expressionTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExpressionValue)
                    .HasColumnName("expressionValue")
                    .HasMaxLength(100);

                entity.Property(e => e.OperandId)
                    .HasColumnName("operandID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Dgmtypeattributes>(entity =>
            {
                entity.HasKey(e => new { e.TypeId, e.AttributeId });

                entity.ToTable("dgmtypeattributes");

                entity.HasIndex(e => e.AttributeId)
                    .HasName("ix_dgmTypeAttributes_attributeID");

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AttributeId)
                    .HasColumnName("attributeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ValueFloat).HasColumnName("valueFloat");

                entity.Property(e => e.ValueInt)
                    .HasColumnName("valueInt")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Dgmtypeeffects>(entity =>
            {
                entity.HasKey(e => new { e.TypeId, e.EffectId });

                entity.ToTable("dgmtypeeffects");

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EffectId)
                    .HasColumnName("effectID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDefault)
                    .HasColumnName("isDefault")
                    .HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<Evegraphics>(entity =>
            {
                entity.HasKey(e => e.GraphicId);

                entity.ToTable("evegraphics");

                entity.Property(e => e.GraphicId)
                    .HasColumnName("graphicID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.GraphicFile)
                    .HasColumnName("graphicFile")
                    .HasMaxLength(100);

                entity.Property(e => e.SofFactionName)
                    .HasColumnName("sofFactionName")
                    .HasMaxLength(100);

                entity.Property(e => e.SofHullName)
                    .HasColumnName("sofHullName")
                    .HasMaxLength(100);

                entity.Property(e => e.SofRaceName)
                    .HasColumnName("sofRaceName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Eveicons>(entity =>
            {
                entity.HasKey(e => e.IconId);

                entity.ToTable("eveicons");

                entity.Property(e => e.IconId)
                    .HasColumnName("iconID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.IconFile)
                    .HasColumnName("iconFile")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Eveunits>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("eveunits");

                entity.Property(e => e.UnitId)
                    .HasColumnName("unitID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("displayName")
                    .HasMaxLength(50);

                entity.Property(e => e.UnitName)
                    .HasColumnName("unitName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Industryactivity>(entity =>
            {
                entity.HasKey(e => new { e.TypeId, e.ActivityId });

                entity.ToTable("industryactivity");

                entity.HasIndex(e => e.ActivityId)
                    .HasName("ix_industryActivity_activityID");

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActivityId)
                    .HasColumnName("activityID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Industryblueprints>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("industryblueprints");

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaxProductionLimit)
                    .HasColumnName("maxProductionLimit")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Invcategories>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("invcategories");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("categoryID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryName)
                    .HasColumnName("categoryName")
                    .HasMaxLength(100);

                entity.Property(e => e.IconId)
                    .HasColumnName("iconID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Published)
                    .HasColumnName("published")
                    .HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<Invcontrabandtypes>(entity =>
            {
                entity.HasKey(e => new { e.FactionId, e.TypeId });

                entity.ToTable("invcontrabandtypes");

                entity.HasIndex(e => e.TypeId)
                    .HasName("ix_invContrabandTypes_typeID");

                entity.Property(e => e.FactionId)
                    .HasColumnName("factionID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AttackMinSec).HasColumnName("attackMinSec");

                entity.Property(e => e.ConfiscateMinSec).HasColumnName("confiscateMinSec");

                entity.Property(e => e.FineByValue).HasColumnName("fineByValue");

                entity.Property(e => e.StandingLoss).HasColumnName("standingLoss");
            });

            modelBuilder.Entity<Invcontroltowerresourcepurposes>(entity =>
            {
                entity.HasKey(e => e.Purpose);

                entity.ToTable("invcontroltowerresourcepurposes");

                entity.Property(e => e.Purpose)
                    .HasColumnName("purpose")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PurposeText)
                    .HasColumnName("purposeText")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Invcontroltowerresources>(entity =>
            {
                entity.HasKey(e => new { e.ControlTowerTypeId, e.ResourceTypeId });

                entity.ToTable("invcontroltowerresources");

                entity.Property(e => e.ControlTowerTypeId)
                    .HasColumnName("controlTowerTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ResourceTypeId)
                    .HasColumnName("resourceTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FactionId)
                    .HasColumnName("factionID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MinSecurityLevel).HasColumnName("minSecurityLevel");

                entity.Property(e => e.Purpose)
                    .HasColumnName("purpose")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Invflags>(entity =>
            {
                entity.HasKey(e => e.FlagId);

                entity.ToTable("invflags");

                entity.Property(e => e.FlagId)
                    .HasColumnName("flagID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FlagName)
                    .HasColumnName("flagName")
                    .HasMaxLength(200);

                entity.Property(e => e.FlagText)
                    .HasColumnName("flagText")
                    .HasMaxLength(100);

                entity.Property(e => e.OrderId)
                    .HasColumnName("orderID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Invgroups>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("invgroups");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("ix_invGroups_categoryID");

                entity.Property(e => e.GroupId)
                    .HasColumnName("groupID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Anchorable)
                    .HasColumnName("anchorable")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Anchored)
                    .HasColumnName("anchored")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("categoryID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FittableNonSingleton)
                    .HasColumnName("fittableNonSingleton")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.GroupName)
                    .HasColumnName("groupName")
                    .HasMaxLength(100);

                entity.Property(e => e.IconId)
                    .HasColumnName("iconID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Published)
                    .HasColumnName("published")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.UseBasePrice)
                    .HasColumnName("useBasePrice")
                    .HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<Invitems>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("invitems");

                entity.HasIndex(e => e.LocationId)
                    .HasName("ix_invItems_locationID");

                entity.HasIndex(e => new { e.OwnerId, e.LocationId })
                    .HasName("items_IX_OwnerLocation");

                entity.Property(e => e.ItemId)
                    .HasColumnName("itemID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FlagId)
                    .HasColumnName("flagID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LocationId)
                    .HasColumnName("locationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("ownerID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Invmarketgroups>(entity =>
            {
                entity.HasKey(e => e.MarketGroupId);

                entity.ToTable("invmarketgroups");

                entity.Property(e => e.MarketGroupId)
                    .HasColumnName("marketGroupID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(3000);

                entity.Property(e => e.HasTypes)
                    .HasColumnName("hasTypes")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.IconId)
                    .HasColumnName("iconID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MarketGroupName)
                    .HasColumnName("marketGroupName")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentGroupId)
                    .HasColumnName("parentGroupID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Invmetagroups>(entity =>
            {
                entity.HasKey(e => e.MetaGroupId);

                entity.ToTable("invmetagroups");

                entity.Property(e => e.MetaGroupId)
                    .HasColumnName("metaGroupID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.IconId)
                    .HasColumnName("iconID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MetaGroupName)
                    .HasColumnName("metaGroupName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Invmetatypes>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("invmetatypes");

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.MetaGroupId)
                    .HasColumnName("metaGroupID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ParentTypeId)
                    .HasColumnName("parentTypeID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Invnames>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("invnames");

                entity.Property(e => e.ItemId)
                    .HasColumnName("itemID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasColumnName("itemName")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Invpositions>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("invpositions");

                entity.Property(e => e.ItemId)
                    .HasColumnName("itemID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Pitch).HasColumnName("pitch");

                entity.Property(e => e.Roll).HasColumnName("roll");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Yaw).HasColumnName("yaw");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<Invtraits>(entity =>
            {
                entity.HasKey(e => e.TraitId);

                entity.ToTable("invtraits");

                entity.Property(e => e.TraitId)
                    .HasColumnName("traitID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bonus).HasColumnName("bonus");

                entity.Property(e => e.BonusText)
                    .HasColumnName("bonusText")
                    .HasColumnType("text");

                entity.Property(e => e.SkillId)
                    .HasColumnName("skillID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UnitId)
                    .HasColumnName("unitID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Invtypematerials>(entity =>
            {
                entity.HasKey(e => new { e.TypeId, e.MaterialTypeId });

                entity.ToTable("invtypematerials");

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaterialTypeId)
                    .HasColumnName("materialTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Invtypereactions>(entity =>
            {
                entity.HasKey(e => new { e.ReactionTypeId, e.Input, e.TypeId });

                entity.ToTable("invtypereactions");

                entity.Property(e => e.ReactionTypeId)
                    .HasColumnName("reactionTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Input)
                    .HasColumnName("input")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Invtypes>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("invtypes");

                entity.HasIndex(e => e.GroupId)
                    .HasName("ix_invTypes_groupID");

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BasePrice)
                    .HasColumnName("basePrice")
                    .HasColumnType("decimal(19,4)");

                entity.Property(e => e.Capacity).HasColumnName("capacity");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.GraphicId)
                    .HasColumnName("graphicID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("groupID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IconId)
                    .HasColumnName("iconID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MarketGroupId)
                    .HasColumnName("marketGroupID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mass).HasColumnName("mass");

                entity.Property(e => e.PortionSize)
                    .HasColumnName("portionSize")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Published)
                    .HasColumnName("published")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.RaceId)
                    .HasColumnName("raceID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SoundId)
                    .HasColumnName("soundID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypeName)
                    .HasColumnName("typeName")
                    .HasMaxLength(100);

                entity.Property(e => e.Volume).HasColumnName("volume");
            });

            modelBuilder.Entity<Invuniquenames>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("invuniquenames");

                entity.HasIndex(e => e.ItemName)
                    .HasName("ix_invUniqueNames_itemName")
                    .IsUnique();

                entity.HasIndex(e => new { e.GroupId, e.ItemName })
                    .HasName("invUniqueNames_IX_GroupName");

                entity.Property(e => e.ItemId)
                    .HasColumnName("itemID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.GroupId)
                    .HasColumnName("groupID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasColumnName("itemName")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Invvolumes>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("invvolumes");

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Volume)
                    .HasColumnName("volume")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Mapcelestialstatistics>(entity =>
            {
                entity.HasKey(e => e.CelestialId);

                entity.ToTable("mapcelestialstatistics");

                entity.Property(e => e.CelestialId)
                    .HasColumnName("celestialID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Density).HasColumnName("density");

                entity.Property(e => e.Eccentricity).HasColumnName("eccentricity");

                entity.Property(e => e.EscapeVelocity).HasColumnName("escapeVelocity");

                entity.Property(e => e.Fragmented)
                    .HasColumnName("fragmented")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Life).HasColumnName("life");

                entity.Property(e => e.Locked)
                    .HasColumnName("locked")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Luminosity).HasColumnName("luminosity");

                entity.Property(e => e.Mass)
                    .HasColumnName("mass")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MassDust).HasColumnName("massDust");

                entity.Property(e => e.MassGas).HasColumnName("massGas");

                entity.Property(e => e.OrbitPeriod).HasColumnName("orbitPeriod");

                entity.Property(e => e.OrbitRadius).HasColumnName("orbitRadius");

                entity.Property(e => e.Pressure).HasColumnName("pressure");

                entity.Property(e => e.Radius).HasColumnName("radius");

                entity.Property(e => e.RotationRate).HasColumnName("rotationRate");

                entity.Property(e => e.SpectralClass)
                    .HasColumnName("spectralClass")
                    .HasMaxLength(10);

                entity.Property(e => e.SurfaceGravity).HasColumnName("surfaceGravity");

                entity.Property(e => e.Temperature).HasColumnName("temperature");
            });

            modelBuilder.Entity<Mapconstellationjumps>(entity =>
            {
                entity.HasKey(e => new { e.FromConstellationId, e.ToConstellationId });

                entity.ToTable("mapconstellationjumps");

                entity.Property(e => e.FromConstellationId)
                    .HasColumnName("fromConstellationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ToConstellationId)
                    .HasColumnName("toConstellationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FromRegionId)
                    .HasColumnName("fromRegionID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ToRegionId)
                    .HasColumnName("toRegionID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Mapconstellations>(entity =>
            {
                entity.HasKey(e => e.ConstellationId);

                entity.ToTable("mapconstellations");

                entity.Property(e => e.ConstellationId)
                    .HasColumnName("constellationID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConstellationName)
                    .HasColumnName("constellationName")
                    .HasMaxLength(100);

                entity.Property(e => e.FactionId)
                    .HasColumnName("factionID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Radius).HasColumnName("radius");

                entity.Property(e => e.RegionId)
                    .HasColumnName("regionID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.XMax).HasColumnName("xMax");

                entity.Property(e => e.XMin).HasColumnName("xMin");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.YMax).HasColumnName("yMax");

                entity.Property(e => e.YMin).HasColumnName("yMin");

                entity.Property(e => e.Z).HasColumnName("z");

                entity.Property(e => e.ZMax).HasColumnName("zMax");

                entity.Property(e => e.ZMin).HasColumnName("zMin");
            });

            modelBuilder.Entity<Mapdenormalize>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("mapdenormalize");

                entity.HasIndex(e => e.ConstellationId)
                    .HasName("ix_mapDenormalize_constellationID");

                entity.HasIndex(e => e.OrbitId)
                    .HasName("ix_mapDenormalize_orbitID");

                entity.HasIndex(e => e.RegionId)
                    .HasName("ix_mapDenormalize_regionID");

                entity.HasIndex(e => e.SolarSystemId)
                    .HasName("ix_mapDenormalize_solarSystemID");

                entity.HasIndex(e => e.TypeId)
                    .HasName("ix_mapDenormalize_typeID");

                entity.HasIndex(e => new { e.GroupId, e.ConstellationId })
                    .HasName("mapDenormalize_IX_groupConstellation");

                entity.HasIndex(e => new { e.GroupId, e.RegionId })
                    .HasName("mapDenormalize_IX_groupRegion");

                entity.HasIndex(e => new { e.GroupId, e.SolarSystemId })
                    .HasName("mapDenormalize_IX_groupSystem");

                entity.Property(e => e.ItemId)
                    .HasColumnName("itemID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CelestialIndex)
                    .HasColumnName("celestialIndex")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConstellationId)
                    .HasColumnName("constellationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("groupID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ItemName)
                    .HasColumnName("itemName")
                    .HasMaxLength(100);

                entity.Property(e => e.OrbitId)
                    .HasColumnName("orbitID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrbitIndex)
                    .HasColumnName("orbitIndex")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Radius).HasColumnName("radius");

                entity.Property(e => e.RegionId)
                    .HasColumnName("regionID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Security).HasColumnName("security");

                entity.Property(e => e.SolarSystemId)
                    .HasColumnName("solarSystemID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<Mapjumps>(entity =>
            {
                entity.HasKey(e => e.StargateId);

                entity.ToTable("mapjumps");

                entity.Property(e => e.StargateId)
                    .HasColumnName("stargateID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DestinationId)
                    .HasColumnName("destinationID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Maplandmarks>(entity =>
            {
                entity.HasKey(e => e.LandmarkId);

                entity.ToTable("maplandmarks");

                entity.Property(e => e.LandmarkId)
                    .HasColumnName("landmarkID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.IconId)
                    .HasColumnName("iconID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LandmarkName)
                    .HasColumnName("landmarkName")
                    .HasMaxLength(100);

                entity.Property(e => e.LocationId)
                    .HasColumnName("locationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<Maplocationscenes>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.ToTable("maplocationscenes");

                entity.Property(e => e.LocationId)
                    .HasColumnName("locationID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.GraphicId)
                    .HasColumnName("graphicID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Maplocationwormholeclasses>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.ToTable("maplocationwormholeclasses");

                entity.Property(e => e.LocationId)
                    .HasColumnName("locationID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.WormholeClassId)
                    .HasColumnName("wormholeClassID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Mapregionjumps>(entity =>
            {
                entity.HasKey(e => new { e.FromRegionId, e.ToRegionId });

                entity.ToTable("mapregionjumps");

                entity.Property(e => e.FromRegionId)
                    .HasColumnName("fromRegionID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ToRegionId)
                    .HasColumnName("toRegionID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Mapregions>(entity =>
            {
                entity.HasKey(e => e.RegionId);

                entity.ToTable("mapregions");

                entity.Property(e => e.RegionId)
                    .HasColumnName("regionID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FactionId)
                    .HasColumnName("factionID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Radius).HasColumnName("radius");

                entity.Property(e => e.RegionName)
                    .HasColumnName("regionName")
                    .HasMaxLength(100);

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.XMax).HasColumnName("xMax");

                entity.Property(e => e.XMin).HasColumnName("xMin");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.YMax).HasColumnName("yMax");

                entity.Property(e => e.YMin).HasColumnName("yMin");

                entity.Property(e => e.Z).HasColumnName("z");

                entity.Property(e => e.ZMax).HasColumnName("zMax");

                entity.Property(e => e.ZMin).HasColumnName("zMin");
            });

            modelBuilder.Entity<Mapsolarsystemjumps>(entity =>
            {
                entity.HasKey(e => new { e.FromSolarSystemId, e.ToSolarSystemId });

                entity.ToTable("mapsolarsystemjumps");

                entity.Property(e => e.FromSolarSystemId)
                    .HasColumnName("fromSolarSystemID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ToSolarSystemId)
                    .HasColumnName("toSolarSystemID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FromConstellationId)
                    .HasColumnName("fromConstellationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FromRegionId)
                    .HasColumnName("fromRegionID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ToConstellationId)
                    .HasColumnName("toConstellationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ToRegionId)
                    .HasColumnName("toRegionID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Mapsolarsystems>(entity =>
            {
                entity.HasKey(e => e.SolarSystemId);

                entity.ToTable("mapsolarsystems");

                entity.HasIndex(e => e.ConstellationId)
                    .HasName("ix_mapSolarSystems_constellationID");

                entity.HasIndex(e => e.RegionId)
                    .HasName("ix_mapSolarSystems_regionID");

                entity.HasIndex(e => e.Security)
                    .HasName("ix_mapSolarSystems_security");

                entity.Property(e => e.SolarSystemId)
                    .HasColumnName("solarSystemID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Border)
                    .HasColumnName("border")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Constellation)
                    .HasColumnName("constellation")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.ConstellationId)
                    .HasColumnName("constellationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Corridor)
                    .HasColumnName("corridor")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.FactionId)
                    .HasColumnName("factionID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fringe)
                    .HasColumnName("fringe")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Hub)
                    .HasColumnName("hub")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.International)
                    .HasColumnName("international")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Luminosity).HasColumnName("luminosity");

                entity.Property(e => e.Radius).HasColumnName("radius");

                entity.Property(e => e.RegionId)
                    .HasColumnName("regionID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Regional)
                    .HasColumnName("regional")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Security).HasColumnName("security");

                entity.Property(e => e.SecurityClass)
                    .HasColumnName("securityClass")
                    .HasMaxLength(2);

                entity.Property(e => e.SolarSystemName)
                    .HasColumnName("solarSystemName")
                    .HasMaxLength(100);

                entity.Property(e => e.SunTypeId)
                    .HasColumnName("sunTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.XMax).HasColumnName("xMax");

                entity.Property(e => e.XMin).HasColumnName("xMin");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.YMax).HasColumnName("yMax");

                entity.Property(e => e.YMin).HasColumnName("yMin");

                entity.Property(e => e.Z).HasColumnName("z");

                entity.Property(e => e.ZMax).HasColumnName("zMax");

                entity.Property(e => e.ZMin).HasColumnName("zMin");
            });

            modelBuilder.Entity<Mapuniverse>(entity =>
            {
                entity.HasKey(e => e.UniverseId);

                entity.ToTable("mapuniverse");

                entity.Property(e => e.UniverseId)
                    .HasColumnName("universeID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Radius).HasColumnName("radius");

                entity.Property(e => e.UniverseName)
                    .HasColumnName("universeName")
                    .HasMaxLength(100);

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.XMax).HasColumnName("xMax");

                entity.Property(e => e.XMin).HasColumnName("xMin");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.YMax).HasColumnName("yMax");

                entity.Property(e => e.YMin).HasColumnName("yMin");

                entity.Property(e => e.Z).HasColumnName("z");

                entity.Property(e => e.ZMax).HasColumnName("zMax");

                entity.Property(e => e.ZMin).HasColumnName("zMin");
            });

            modelBuilder.Entity<Planetschematics>(entity =>
            {
                entity.HasKey(e => e.SchematicId);

                entity.ToTable("planetschematics");

                entity.Property(e => e.SchematicId)
                    .HasColumnName("schematicID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CycleTime)
                    .HasColumnName("cycleTime")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SchematicName)
                    .HasColumnName("schematicName")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Planetschematicspinmap>(entity =>
            {
                entity.HasKey(e => new { e.SchematicId, e.PinTypeId });

                entity.ToTable("planetschematicspinmap");

                entity.Property(e => e.SchematicId)
                    .HasColumnName("schematicID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PinTypeId)
                    .HasColumnName("pinTypeID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Planetschematicstypemap>(entity =>
            {
                entity.HasKey(e => new { e.SchematicId, e.TypeId });

                entity.ToTable("planetschematicstypemap");

                entity.Property(e => e.SchematicId)
                    .HasColumnName("schematicID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsInput)
                    .HasColumnName("isInput")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Ramactivities>(entity =>
            {
                entity.HasKey(e => e.ActivityId);

                entity.ToTable("ramactivities");

                entity.Property(e => e.ActivityId)
                    .HasColumnName("activityID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityName)
                    .HasColumnName("activityName")
                    .HasMaxLength(100);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.IconNo)
                    .HasColumnName("iconNo")
                    .HasMaxLength(5);

                entity.Property(e => e.Published)
                    .HasColumnName("published")
                    .HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<Ramassemblylinestations>(entity =>
            {
                entity.HasKey(e => new { e.StationId, e.AssemblyLineTypeId });

                entity.ToTable("ramassemblylinestations");

                entity.HasIndex(e => e.OwnerId)
                    .HasName("ix_ramAssemblyLineStations_ownerID");

                entity.HasIndex(e => e.RegionId)
                    .HasName("ix_ramAssemblyLineStations_regionID");

                entity.HasIndex(e => e.SolarSystemId)
                    .HasName("ix_ramAssemblyLineStations_solarSystemID");

                entity.Property(e => e.StationId)
                    .HasColumnName("stationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AssemblyLineTypeId)
                    .HasColumnName("assemblyLineTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("ownerID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RegionId)
                    .HasColumnName("regionID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SolarSystemId)
                    .HasColumnName("solarSystemID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StationTypeId)
                    .HasColumnName("stationTypeID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Ramassemblylinetypedetailpercategory>(entity =>
            {
                entity.HasKey(e => new { e.AssemblyLineTypeId, e.CategoryId });

                entity.ToTable("ramassemblylinetypedetailpercategory");

                entity.Property(e => e.AssemblyLineTypeId)
                    .HasColumnName("assemblyLineTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("categoryID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CostMultiplier).HasColumnName("costMultiplier");

                entity.Property(e => e.MaterialMultiplier).HasColumnName("materialMultiplier");

                entity.Property(e => e.TimeMultiplier).HasColumnName("timeMultiplier");
            });

            modelBuilder.Entity<Ramassemblylinetypedetailpergroup>(entity =>
            {
                entity.HasKey(e => new { e.AssemblyLineTypeId, e.GroupId });

                entity.ToTable("ramassemblylinetypedetailpergroup");

                entity.Property(e => e.AssemblyLineTypeId)
                    .HasColumnName("assemblyLineTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("groupID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CostMultiplier).HasColumnName("costMultiplier");

                entity.Property(e => e.MaterialMultiplier).HasColumnName("materialMultiplier");

                entity.Property(e => e.TimeMultiplier).HasColumnName("timeMultiplier");
            });

            modelBuilder.Entity<Ramassemblylinetypes>(entity =>
            {
                entity.HasKey(e => e.AssemblyLineTypeId);

                entity.ToTable("ramassemblylinetypes");

                entity.Property(e => e.AssemblyLineTypeId)
                    .HasColumnName("assemblyLineTypeID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId)
                    .HasColumnName("activityID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AssemblyLineTypeName)
                    .HasColumnName("assemblyLineTypeName")
                    .HasMaxLength(100);

                entity.Property(e => e.BaseCostMultiplier).HasColumnName("baseCostMultiplier");

                entity.Property(e => e.BaseMaterialMultiplier).HasColumnName("baseMaterialMultiplier");

                entity.Property(e => e.BaseTimeMultiplier).HasColumnName("baseTimeMultiplier");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.MinCostPerHour).HasColumnName("minCostPerHour");

                entity.Property(e => e.Volume).HasColumnName("volume");
            });

            modelBuilder.Entity<Raminstallationtypecontents>(entity =>
            {
                entity.HasKey(e => new { e.InstallationTypeId, e.AssemblyLineTypeId });

                entity.ToTable("raminstallationtypecontents");

                entity.Property(e => e.InstallationTypeId)
                    .HasColumnName("installationTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AssemblyLineTypeId)
                    .HasColumnName("assemblyLineTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Skinlicense>(entity =>
            {
                entity.HasKey(e => e.LicenseTypeId);

                entity.ToTable("skinlicense");

                entity.Property(e => e.LicenseTypeId)
                    .HasColumnName("licenseTypeID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SkinId)
                    .HasColumnName("skinID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Skinmaterials>(entity =>
            {
                entity.HasKey(e => e.SkinMaterialId);

                entity.ToTable("skinmaterials");

                entity.Property(e => e.SkinMaterialId)
                    .HasColumnName("skinMaterialID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisplayNameId)
                    .HasColumnName("displayNameID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaterialSetId)
                    .HasColumnName("materialSetID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Skins>(entity =>
            {
                entity.HasKey(e => e.SkinId);

                entity.ToTable("skins");

                entity.Property(e => e.SkinId)
                    .HasColumnName("skinID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.InternalName)
                    .HasColumnName("internalName")
                    .HasMaxLength(70);

                entity.Property(e => e.SkinMaterialId)
                    .HasColumnName("skinMaterialID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Staoperations>(entity =>
            {
                entity.HasKey(e => e.OperationId);

                entity.ToTable("staoperations");

                entity.Property(e => e.OperationId)
                    .HasColumnName("operationID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId)
                    .HasColumnName("activityID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AmarrStationTypeId)
                    .HasColumnName("amarrStationTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Border)
                    .HasColumnName("border")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CaldariStationTypeId)
                    .HasColumnName("caldariStationTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Corridor)
                    .HasColumnName("corridor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.Fringe)
                    .HasColumnName("fringe")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GallenteStationTypeId)
                    .HasColumnName("gallenteStationTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Hub)
                    .HasColumnName("hub")
                    .HasColumnType("int(11)");

                entity.Property(e => e.JoveStationTypeId)
                    .HasColumnName("joveStationTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MinmatarStationTypeId)
                    .HasColumnName("minmatarStationTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OperationName)
                    .HasColumnName("operationName")
                    .HasMaxLength(100);

                entity.Property(e => e.Ratio)
                    .HasColumnName("ratio")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Staoperationservices>(entity =>
            {
                entity.HasKey(e => new { e.OperationId, e.ServiceId });

                entity.ToTable("staoperationservices");

                entity.Property(e => e.OperationId)
                    .HasColumnName("operationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceId)
                    .HasColumnName("serviceID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Staservices>(entity =>
            {
                entity.HasKey(e => e.ServiceId);

                entity.ToTable("staservices");

                entity.Property(e => e.ServiceId)
                    .HasColumnName("serviceID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.ServiceName)
                    .HasColumnName("serviceName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Stastations>(entity =>
            {
                entity.HasKey(e => e.StationId);

                entity.ToTable("stastations");

                entity.HasIndex(e => e.ConstellationId)
                    .HasName("ix_staStations_constellationID");

                entity.HasIndex(e => e.CorporationId)
                    .HasName("ix_staStations_corporationID");

                entity.HasIndex(e => e.OperationId)
                    .HasName("ix_staStations_operationID");

                entity.HasIndex(e => e.RegionId)
                    .HasName("ix_staStations_regionID");

                entity.HasIndex(e => e.SolarSystemId)
                    .HasName("ix_staStations_solarSystemID");

                entity.HasIndex(e => e.StationTypeId)
                    .HasName("ix_staStations_stationTypeID");

                entity.Property(e => e.StationId)
                    .HasColumnName("stationID")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConstellationId)
                    .HasColumnName("constellationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorporationId)
                    .HasColumnName("corporationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DockingCostPerVolume).HasColumnName("dockingCostPerVolume");

                entity.Property(e => e.MaxShipVolumeDockable).HasColumnName("maxShipVolumeDockable");

                entity.Property(e => e.OfficeRentalCost)
                    .HasColumnName("officeRentalCost")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OperationId)
                    .HasColumnName("operationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RegionId)
                    .HasColumnName("regionID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReprocessingEfficiency).HasColumnName("reprocessingEfficiency");

                entity.Property(e => e.ReprocessingHangarFlag)
                    .HasColumnName("reprocessingHangarFlag")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReprocessingStationsTake).HasColumnName("reprocessingStationsTake");

                entity.Property(e => e.Security).HasColumnName("security");

                entity.Property(e => e.SolarSystemId)
                    .HasColumnName("solarSystemID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StationName)
                    .HasColumnName("stationName")
                    .HasMaxLength(100);

                entity.Property(e => e.StationTypeId)
                    .HasColumnName("stationTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<Stastationtypes>(entity =>
            {
                entity.HasKey(e => e.StationTypeId);

                entity.ToTable("stastationtypes");

                entity.Property(e => e.StationTypeId)
                    .HasColumnName("stationTypeID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Conquerable)
                    .HasColumnName("conquerable")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.DockEntryX).HasColumnName("dockEntryX");

                entity.Property(e => e.DockEntryY).HasColumnName("dockEntryY");

                entity.Property(e => e.DockEntryZ).HasColumnName("dockEntryZ");

                entity.Property(e => e.DockOrientationX).HasColumnName("dockOrientationX");

                entity.Property(e => e.DockOrientationY).HasColumnName("dockOrientationY");

                entity.Property(e => e.DockOrientationZ).HasColumnName("dockOrientationZ");

                entity.Property(e => e.OfficeSlots)
                    .HasColumnName("officeSlots")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OperationId)
                    .HasColumnName("operationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReprocessingEfficiency).HasColumnName("reprocessingEfficiency");
            });

            modelBuilder.Entity<Translationtables>(entity =>
            {
                entity.HasKey(e => new { e.SourceTable, e.TranslatedKey });

                entity.ToTable("translationtables");

                entity.Property(e => e.SourceTable)
                    .HasColumnName("sourceTable")
                    .HasMaxLength(200);

                entity.Property(e => e.TranslatedKey)
                    .HasColumnName("translatedKey")
                    .HasMaxLength(200);

                entity.Property(e => e.DestinationTable)
                    .HasColumnName("destinationTable")
                    .HasMaxLength(200);

                entity.Property(e => e.TcGroupId)
                    .HasColumnName("tcGroupID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TcId)
                    .HasColumnName("tcID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Trntranslationcolumns>(entity =>
            {
                entity.HasKey(e => e.TcId);

                entity.ToTable("trntranslationcolumns");

                entity.Property(e => e.TcId)
                    .HasColumnName("tcID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasColumnName("columnName")
                    .HasMaxLength(128);

                entity.Property(e => e.MasterId)
                    .HasColumnName("masterID")
                    .HasMaxLength(128);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasColumnName("tableName")
                    .HasMaxLength(256);

                entity.Property(e => e.TcGroupId)
                    .HasColumnName("tcGroupID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Trntranslationlanguages>(entity =>
            {
                entity.HasKey(e => e.NumericLanguageId);

                entity.ToTable("trntranslationlanguages");

                entity.Property(e => e.NumericLanguageId)
                    .HasColumnName("numericLanguageID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LanguageId)
                    .HasColumnName("languageID")
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageName)
                    .HasColumnName("languageName")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Trntranslations>(entity =>
            {
                entity.HasKey(e => new { e.TcId, e.KeyId, e.LanguageId });

                entity.ToTable("trntranslations");

                entity.Property(e => e.TcId)
                    .HasColumnName("tcID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.KeyId)
                    .HasColumnName("keyID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("languageID")
                    .HasMaxLength(50);

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Warcombatzones>(entity =>
            {
                entity.HasKey(e => e.CombatZoneId);

                entity.ToTable("warcombatzones");

                entity.Property(e => e.CombatZoneId)
                    .HasColumnName("combatZoneID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CenterSystemId)
                    .HasColumnName("centerSystemID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CombatZoneName)
                    .HasColumnName("combatZoneName")
                    .HasMaxLength(100);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500);

                entity.Property(e => e.FactionId)
                    .HasColumnName("factionID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Warcombatzonesystems>(entity =>
            {
                entity.HasKey(e => e.SolarSystemId);

                entity.ToTable("warcombatzonesystems");

                entity.Property(e => e.SolarSystemId)
                    .HasColumnName("solarSystemID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CombatZoneId)
                    .HasColumnName("combatZoneID")
                    .HasColumnType("int(11)");
            });
        }
    }
}
