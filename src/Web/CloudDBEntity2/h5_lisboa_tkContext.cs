using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CloudDBEntity2
{
    public partial class h5_lisboa_tkContext : DbContext
    {
        public h5_lisboa_tkContext()
        {
        }

        public h5_lisboa_tkContext(DbContextOptions<h5_lisboa_tkContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LcsAccountLog> LcsAccountLog { get; set; }
        public virtual DbSet<LcsAccountOtherLog> LcsAccountOtherLog { get; set; }
        public virtual DbSet<LcsAd> LcsAd { get; set; }
        public virtual DbSet<LcsAdCustom> LcsAdCustom { get; set; }
        public virtual DbSet<LcsAdPosition> LcsAdPosition { get; set; }
        public virtual DbSet<LcsAdminAction> LcsAdminAction { get; set; }
        public virtual DbSet<LcsAdminLog> LcsAdminLog { get; set; }
        public virtual DbSet<LcsAdminMessage> LcsAdminMessage { get; set; }
        public virtual DbSet<LcsAdminUser> LcsAdminUser { get; set; }
        public virtual DbSet<LcsAdsense> LcsAdsense { get; set; }
        public virtual DbSet<LcsAffiliateLog> LcsAffiliateLog { get; set; }
        public virtual DbSet<LcsAgency> LcsAgency { get; set; }
        public virtual DbSet<LcsAreaRegion> LcsAreaRegion { get; set; }
        public virtual DbSet<LcsArticle> LcsArticle { get; set; }
        public virtual DbSet<LcsArticleCat> LcsArticleCat { get; set; }
        public virtual DbSet<LcsAttribute> LcsAttribute { get; set; }
        public virtual DbSet<LcsAuctionLog> LcsAuctionLog { get; set; }
        public virtual DbSet<LcsAutoManage> LcsAutoManage { get; set; }
        public virtual DbSet<LcsBackGoods> LcsBackGoods { get; set; }
        public virtual DbSet<LcsBackOrder> LcsBackOrder { get; set; }
        public virtual DbSet<LcsBonusType> LcsBonusType { get; set; }
        public virtual DbSet<LcsBookingGoods> LcsBookingGoods { get; set; }
        public virtual DbSet<LcsBrand> LcsBrand { get; set; }
        public virtual DbSet<LcsCallbackStatus> LcsCallbackStatus { get; set; }
        public virtual DbSet<LcsCard> LcsCard { get; set; }
        public virtual DbSet<LcsCart> LcsCart { get; set; }
        public virtual DbSet<LcsCatRecommend> LcsCatRecommend { get; set; }
        public virtual DbSet<LcsCategory> LcsCategory { get; set; }
        public virtual DbSet<LcsCert> LcsCert { get; set; }
        public virtual DbSet<LcsCoincidence> LcsCoincidence { get; set; }
        public virtual DbSet<LcsCollectGoods> LcsCollectGoods { get; set; }
        public virtual DbSet<LcsComment> LcsComment { get; set; }
        public virtual DbSet<LcsConfig> LcsConfig { get; set; }
        public virtual DbSet<LcsCrons> LcsCrons { get; set; }
        public virtual DbSet<LcsDeliveryGoods> LcsDeliveryGoods { get; set; }
        public virtual DbSet<LcsDeliveryOrder> LcsDeliveryOrder { get; set; }
        public virtual DbSet<LcsDevice> LcsDevice { get; set; }
        public virtual DbSet<LcsEmailList> LcsEmailList { get; set; }
        public virtual DbSet<LcsEmailSendlist> LcsEmailSendlist { get; set; }
        public virtual DbSet<LcsErrorLog> LcsErrorLog { get; set; }
        public virtual DbSet<LcsExchangeGoods> LcsExchangeGoods { get; set; }
        public virtual DbSet<LcsFavourableActivity> LcsFavourableActivity { get; set; }
        public virtual DbSet<LcsFeedback> LcsFeedback { get; set; }
        public virtual DbSet<LcsFriendLink> LcsFriendLink { get; set; }
        public virtual DbSet<LcsGoods> LcsGoods { get; set; }
        public virtual DbSet<LcsGoodsActivity> LcsGoodsActivity { get; set; }
        public virtual DbSet<LcsGoodsArticle> LcsGoodsArticle { get; set; }
        public virtual DbSet<LcsGoodsAttr> LcsGoodsAttr { get; set; }
        public virtual DbSet<LcsGoodsCat> LcsGoodsCat { get; set; }
        public virtual DbSet<LcsGoodsGallery> LcsGoodsGallery { get; set; }
        public virtual DbSet<LcsGoodsType> LcsGoodsType { get; set; }
        public virtual DbSet<LcsGroupGoods> LcsGroupGoods { get; set; }
        public virtual DbSet<LcsKeywords> LcsKeywords { get; set; }
        public virtual DbSet<LcsLinkGoods> LcsLinkGoods { get; set; }
        public virtual DbSet<LcsMailTemplates> LcsMailTemplates { get; set; }
        public virtual DbSet<LcsMemberPrice> LcsMemberPrice { get; set; }
        public virtual DbSet<LcsNav> LcsNav { get; set; }
        public virtual DbSet<LcsOrderAction> LcsOrderAction { get; set; }
        public virtual DbSet<LcsOrderGoods> LcsOrderGoods { get; set; }
        public virtual DbSet<LcsOrderInfo> LcsOrderInfo { get; set; }
        public virtual DbSet<LcsOrderReview> LcsOrderReview { get; set; }
        public virtual DbSet<LcsPack> LcsPack { get; set; }
        public virtual DbSet<LcsPackageGoods> LcsPackageGoods { get; set; }
        public virtual DbSet<LcsPayLog> LcsPayLog { get; set; }
        public virtual DbSet<LcsPayment> LcsPayment { get; set; }
        public virtual DbSet<LcsPlugins> LcsPlugins { get; set; }
        public virtual DbSet<LcsProducts> LcsProducts { get; set; }
        public virtual DbSet<LcsPush> LcsPush { get; set; }
        public virtual DbSet<LcsRegExtendInfo> LcsRegExtendInfo { get; set; }
        public virtual DbSet<LcsRegFields> LcsRegFields { get; set; }
        public virtual DbSet<LcsRegion> LcsRegion { get; set; }
        public virtual DbSet<LcsRole> LcsRole { get; set; }
        public virtual DbSet<LcsSearchHistory> LcsSearchHistory { get; set; }
        public virtual DbSet<LcsSearchengine> LcsSearchengine { get; set; }
        public virtual DbSet<LcsSessions> LcsSessions { get; set; }
        public virtual DbSet<LcsSessionsData> LcsSessionsData { get; set; }
        public virtual DbSet<LcsShipping> LcsShipping { get; set; }
        public virtual DbSet<LcsShippingArea> LcsShippingArea { get; set; }
        public virtual DbSet<LcsShopBind> LcsShopBind { get; set; }
        public virtual DbSet<LcsShopConfig> LcsShopConfig { get; set; }
        public virtual DbSet<LcsSnatchLog> LcsSnatchLog { get; set; }
        public virtual DbSet<LcsSns> LcsSns { get; set; }
        public virtual DbSet<LcsStats> LcsStats { get; set; }
        public virtual DbSet<LcsSuppliers> LcsSuppliers { get; set; }
        public virtual DbSet<LcsTag> LcsTag { get; set; }
        public virtual DbSet<LcsTemplate> LcsTemplate { get; set; }
        public virtual DbSet<LcsTopic> LcsTopic { get; set; }
        public virtual DbSet<LcsUserAccount> LcsUserAccount { get; set; }
        public virtual DbSet<LcsUserAddress> LcsUserAddress { get; set; }
        public virtual DbSet<LcsUserBonus> LcsUserBonus { get; set; }
        public virtual DbSet<LcsUserFeed> LcsUserFeed { get; set; }
        public virtual DbSet<LcsUserRank> LcsUserRank { get; set; }
        public virtual DbSet<LcsUserRegStatus> LcsUserRegStatus { get; set; }
        public virtual DbSet<LcsUsers> LcsUsers { get; set; }
        public virtual DbSet<LcsVersion> LcsVersion { get; set; }
        public virtual DbSet<LcsVirtualCard> LcsVirtualCard { get; set; }
        public virtual DbSet<LcsVolumePrice> LcsVolumePrice { get; set; }
        public virtual DbSet<LcsVote> LcsVote { get; set; }
        public virtual DbSet<LcsVoteLog> LcsVoteLog { get; set; }
        public virtual DbSet<LcsVoteOption> LcsVoteOption { get; set; }
        public virtual DbSet<LcsWholesale> LcsWholesale { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=h5.lisboa.tk;user id=h5_lisboa_tk;password=74EpHAZtfJ;database=h5_lisboa_tk", x => x.ServerVersion("5.6.49-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LcsAccountLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_account_log");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.LogId)
                    .HasColumnName("log_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.ChangeDesc)
                    .IsRequired()
                    .HasColumnName("change_desc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChangeTime)
                    .HasColumnName("change_time")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ChangeType)
                    .HasColumnName("change_type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.FrozenMoney)
                    .HasColumnName("frozen_money")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.PayPoints)
                    .HasColumnName("pay_points")
                    .HasColumnType("mediumint(9)");

                entity.Property(e => e.RankPoints)
                    .HasColumnName("rank_points")
                    .HasColumnType("mediumint(9)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.UserMoney)
                    .HasColumnName("user_money")
                    .HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<LcsAccountOtherLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lcs_account_other_log");

                entity.Property(e => e.ChangeDesc)
                    .IsRequired()
                    .HasColumnName("change_desc")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Money)
                    .HasColumnName("money")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.OrderSn)
                    .IsRequired()
                    .HasColumnName("order_sn")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayTime)
                    .IsRequired()
                    .HasColumnName("pay_time")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasColumnName("pay_type")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("mediumint(8)");
            });

            modelBuilder.Entity<LcsAd>(entity =>
            {
                entity.HasKey(e => e.AdId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_ad");

                entity.HasIndex(e => e.Enabled)
                    .HasName("enabled");

                entity.HasIndex(e => e.PositionId)
                    .HasName("position_id");

                entity.Property(e => e.AdId)
                    .HasColumnName("ad_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.AdCode)
                    .IsRequired()
                    .HasColumnName("ad_code")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AdLink)
                    .IsRequired()
                    .HasColumnName("ad_link")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AdName)
                    .IsRequired()
                    .HasColumnName("ad_name")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClickCount)
                    .HasColumnName("click_count")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LinkEmail)
                    .IsRequired()
                    .HasColumnName("link_email")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LinkMan)
                    .IsRequired()
                    .HasColumnName("link_man")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LinkPhone)
                    .IsRequired()
                    .HasColumnName("link_phone")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MediaType)
                    .HasColumnName("media_type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.PositionId)
                    .HasColumnName("position_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.StartTime)
                    .HasColumnName("start_time")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<LcsAdCustom>(entity =>
            {
                entity.HasKey(e => e.AdId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_ad_custom");

                entity.Property(e => e.AdId)
                    .HasColumnName("ad_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.AdName)
                    .HasColumnName("ad_name")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AdStatus)
                    .HasColumnName("ad_status")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.AdType)
                    .HasColumnName("ad_type")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsAdPosition>(entity =>
            {
                entity.HasKey(e => e.PositionId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_ad_position");

                entity.Property(e => e.PositionId)
                    .HasColumnName("position_id")
                    .HasColumnType("tinyint(3) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AdHeight)
                    .HasColumnName("ad_height")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.AdWidth)
                    .HasColumnName("ad_width")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.PositionDesc)
                    .IsRequired()
                    .HasColumnName("position_desc")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PositionName)
                    .IsRequired()
                    .HasColumnName("position_name")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PositionStyle)
                    .IsRequired()
                    .HasColumnName("position_style")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsAdminAction>(entity =>
            {
                entity.HasKey(e => e.ActionId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_admin_action");

                entity.HasIndex(e => e.ParentId)
                    .HasName("parent_id");

                entity.Property(e => e.ActionId)
                    .HasColumnName("action_id")
                    .HasColumnType("tinyint(3) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActionCode)
                    .IsRequired()
                    .HasColumnName("action_code")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Relevance)
                    .IsRequired()
                    .HasColumnName("relevance")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsAdminLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_admin_log");

                entity.HasIndex(e => e.LogTime)
                    .HasName("log_time");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.LogId)
                    .HasColumnName("log_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasColumnName("ip_address")
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LogInfo)
                    .IsRequired()
                    .HasColumnName("log_info")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LogTime)
                    .HasColumnName("log_time")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<LcsAdminMessage>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_admin_message");

                entity.HasIndex(e => e.ReceiverId)
                    .HasName("receiver_id");

                entity.HasIndex(e => new { e.SenderId, e.ReceiverId })
                    .HasName("sender_id");

                entity.Property(e => e.MessageId)
                    .HasColumnName("message_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReadTime)
                    .HasColumnName("read_time")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Readed)
                    .HasColumnName("readed")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.ReceiverId)
                    .HasColumnName("receiver_id")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.SenderId)
                    .HasColumnName("sender_id")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.SentTime)
                    .HasColumnName("sent_time")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsAdminUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_admin_user");

                entity.HasIndex(e => e.AgencyId)
                    .HasName("agency_id");

                entity.HasIndex(e => e.UserName)
                    .HasName("user_name");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ActionList)
                    .IsRequired()
                    .HasColumnName("action_list")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AgencyId)
                    .HasColumnName("agency_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.EcSalt)
                    .HasColumnName("ec_salt")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LangType)
                    .IsRequired()
                    .HasColumnName("lang_type")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastIp)
                    .IsRequired()
                    .HasColumnName("last_ip")
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastLogin)
                    .HasColumnName("last_login")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NavList)
                    .IsRequired()
                    .HasColumnName("nav_list")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PassportUid)
                    .HasColumnName("passport_uid")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasColumnType("smallint(5)");

                entity.Property(e => e.SuppliersId)
                    .HasColumnName("suppliers_id")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Todolist)
                    .HasColumnName("todolist")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.YqCreateTime)
                    .HasColumnName("yq_create_time")
                    .HasColumnType("smallint(11)");
            });

            modelBuilder.Entity<LcsAdsense>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lcs_adsense");

                entity.HasIndex(e => e.FromAd)
                    .HasName("from_ad");

                entity.Property(e => e.Clicks)
                    .HasColumnName("clicks")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.FromAd)
                    .HasColumnName("from_ad")
                    .HasColumnType("smallint(5)");

                entity.Property(e => e.Referer)
                    .IsRequired()
                    .HasColumnName("referer")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsAffiliateLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_affiliate_log");

                entity.Property(e => e.LogId)
                    .HasColumnName("log_id")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.Money)
                    .HasColumnName("money")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.Point)
                    .HasColumnName("point")
                    .HasColumnType("int(10)");

                entity.Property(e => e.SeparateType).HasColumnName("separate_type");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(10)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsAgency>(entity =>
            {
                entity.HasKey(e => e.AgencyId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_agency");

                entity.HasIndex(e => e.AgencyName)
                    .HasName("agency_name");

                entity.Property(e => e.AgencyId)
                    .HasColumnName("agency_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.AgencyDesc)
                    .IsRequired()
                    .HasColumnName("agency_desc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AgencyName)
                    .IsRequired()
                    .HasColumnName("agency_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsAreaRegion>(entity =>
            {
                entity.HasKey(e => new { e.ShippingAreaId, e.RegionId })
                    .HasName("PRIMARY");

                entity.ToTable("lcs_area_region");

                entity.Property(e => e.ShippingAreaId)
                    .HasColumnName("shipping_area_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RegionId)
                    .HasColumnName("region_id")
                    .HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<LcsArticle>(entity =>
            {
                entity.HasKey(e => e.ArticleId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_article");

                entity.HasIndex(e => e.CatId)
                    .HasName("cat_id");

                entity.Property(e => e.ArticleId)
                    .HasColumnName("article_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ArticleType)
                    .HasColumnName("article_type")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasColumnName("author")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AuthorEmail)
                    .IsRequired()
                    .HasColumnName("author_email")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CatId)
                    .HasColumnName("cat_id")
                    .HasColumnType("smallint(5)");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FileUrl)
                    .IsRequired()
                    .HasColumnName("file_url")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsOpen)
                    .HasColumnName("is_open")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Keywords)
                    .IsRequired()
                    .HasColumnName("keywords")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasColumnName("link")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OpenType)
                    .HasColumnName("open_type")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsArticleCat>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_article_cat");

                entity.HasIndex(e => e.CatType)
                    .HasName("cat_type");

                entity.HasIndex(e => e.ParentId)
                    .HasName("parent_id");

                entity.HasIndex(e => e.SortOrder)
                    .HasName("sort_order");

                entity.Property(e => e.CatId)
                    .HasColumnName("cat_id")
                    .HasColumnType("smallint(5)");

                entity.Property(e => e.CatDesc)
                    .IsRequired()
                    .HasColumnName("cat_desc")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CatName)
                    .IsRequired()
                    .HasColumnName("cat_name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CatType)
                    .HasColumnName("cat_type")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Keywords)
                    .IsRequired()
                    .HasColumnName("keywords")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ShowInNav)
                    .HasColumnName("show_in_nav")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("sort_order")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'50'");
            });

            modelBuilder.Entity<LcsAttribute>(entity =>
            {
                entity.HasKey(e => e.AttrId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_attribute");

                entity.HasIndex(e => e.CatId)
                    .HasName("cat_id");

                entity.Property(e => e.AttrId)
                    .HasColumnName("attr_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.AttrGroup)
                    .HasColumnName("attr_group")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.AttrIndex)
                    .HasColumnName("attr_index")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.AttrInputType)
                    .HasColumnName("attr_input_type")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.AttrName)
                    .IsRequired()
                    .HasColumnName("attr_name")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AttrType)
                    .HasColumnName("attr_type")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.AttrValues)
                    .IsRequired()
                    .HasColumnName("attr_values")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CatId)
                    .HasColumnName("cat_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.IsLinked)
                    .HasColumnName("is_linked")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("sort_order")
                    .HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<LcsAuctionLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_auction_log");

                entity.HasIndex(e => e.ActId)
                    .HasName("act_id");

                entity.Property(e => e.LogId)
                    .HasColumnName("log_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.ActId)
                    .HasColumnName("act_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.BidPrice)
                    .HasColumnName("bid_price")
                    .HasColumnType("decimal(10,2) unsigned");

                entity.Property(e => e.BidTime)
                    .HasColumnName("bid_time")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.BidUser)
                    .HasColumnName("bid_user")
                    .HasColumnType("mediumint(8) unsigned");
            });

            modelBuilder.Entity<LcsAutoManage>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.Type })
                    .HasName("PRIMARY");

                entity.ToTable("lcs_auto_manage");

                entity.Property(e => e.ItemId)
                    .HasColumnName("item_id")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Endtime)
                    .HasColumnName("endtime")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Starttime)
                    .HasColumnName("starttime")
                    .HasColumnType("int(10)");
            });

            modelBuilder.Entity<LcsBackGoods>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_back_goods");

                entity.HasIndex(e => e.BackId)
                    .HasName("back_id");

                entity.HasIndex(e => e.GoodsId)
                    .HasName("goods_id");

                entity.Property(e => e.RecId)
                    .HasColumnName("rec_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.BackId)
                    .HasColumnName("back_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BrandName)
                    .HasColumnName("brand_name")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsAttr)
                    .HasColumnName("goods_attr")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GoodsName)
                    .HasColumnName("goods_name")
                    .HasColumnType("varchar(120)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsSn)
                    .HasColumnName("goods_sn")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsReal)
                    .HasColumnName("is_real")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProductSn)
                    .HasColumnName("product_sn")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SendNumber)
                    .HasColumnName("send_number")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<LcsBackOrder>(entity =>
            {
                entity.HasKey(e => e.BackId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_back_order");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.BackId)
                    .HasColumnName("back_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.ActionUser)
                    .HasColumnName("action_user")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AgencyId)
                    .HasColumnName("agency_id")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BestTime)
                    .HasColumnName("best_time")
                    .HasColumnType("varchar(120)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Consignee)
                    .HasColumnName("consignee")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DeliverySn)
                    .IsRequired()
                    .HasColumnName("delivery_sn")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HowOos)
                    .HasColumnName("how_oos")
                    .HasColumnType("varchar(120)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InsureFee)
                    .HasColumnName("insure_fee")
                    .HasColumnType("decimal(10,2) unsigned")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("invoice_no")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OrderSn)
                    .IsRequired()
                    .HasColumnName("order_sn")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Postscript)
                    .HasColumnName("postscript")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ReturnTime)
                    .HasColumnName("return_time")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ShippingFee)
                    .HasColumnName("shipping_fee")
                    .HasColumnType("decimal(10,2) unsigned")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.ShippingId)
                    .HasColumnName("shipping_id")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ShippingName)
                    .HasColumnName("shipping_name")
                    .HasColumnType("varchar(120)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SignBuilding)
                    .HasColumnName("sign_building")
                    .HasColumnType("varchar(120)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.SuppliersId)
                    .HasColumnName("suppliers_id")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsBonusType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_bonus_type");

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.MaxAmount)
                    .HasColumnName("max_amount")
                    .HasColumnType("decimal(10,2) unsigned");

                entity.Property(e => e.MinAmount)
                    .HasColumnName("min_amount")
                    .HasColumnType("decimal(10,2) unsigned");

                entity.Property(e => e.MinGoodsAmount)
                    .HasColumnName("min_goods_amount")
                    .HasColumnType("decimal(10,2) unsigned");

                entity.Property(e => e.SendEndDate)
                    .HasColumnName("send_end_date")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SendStartDate)
                    .HasColumnName("send_start_date")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SendType)
                    .HasColumnName("send_type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.TypeMoney)
                    .HasColumnName("type_money")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasColumnName("type_name")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UseEndDate)
                    .HasColumnName("use_end_date")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UseStartDate)
                    .HasColumnName("use_start_date")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<LcsBookingGoods>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_booking_goods");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.RecId)
                    .HasColumnName("rec_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.BookingTime)
                    .HasColumnName("booking_time")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DisposeNote)
                    .IsRequired()
                    .HasColumnName("dispose_note")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DisposeTime)
                    .HasColumnName("dispose_time")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DisposeUser)
                    .IsRequired()
                    .HasColumnName("dispose_user")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsDesc)
                    .IsRequired()
                    .HasColumnName("goods_desc")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GoodsNumber)
                    .HasColumnName("goods_number")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.IsDispose)
                    .HasColumnName("is_dispose")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.LinkMan)
                    .IsRequired()
                    .HasColumnName("link_man")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasColumnName("tel")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<LcsBrand>(entity =>
            {
                entity.HasKey(e => e.BrandId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_brand");

                entity.HasIndex(e => e.IsShow)
                    .HasName("is_show");

                entity.Property(e => e.BrandId)
                    .HasColumnName("brand_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.BrandDesc)
                    .IsRequired()
                    .HasColumnName("brand_desc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BrandLogo)
                    .IsRequired()
                    .HasColumnName("brand_logo")
                    .HasColumnType("varchar(80)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasColumnName("brand_name")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsShow)
                    .HasColumnName("is_show")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SiteUrl)
                    .IsRequired()
                    .HasColumnName("site_url")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("sort_order")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'50'");
            });

            modelBuilder.Entity<LcsCallbackStatus>(entity =>
            {
                entity.ToTable("lcs_callback_status");

                entity.HasIndex(e => e.DateTime)
                    .HasName("date_time");

                entity.HasIndex(e => e.Status)
                    .HasName("ind_status");

                entity.HasIndex(e => new { e.Type, e.TypeId })
                    .HasName("ind_type_type_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateTime)
                    .HasColumnName("date_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Disabled)
                    .HasColumnName("disabled")
                    .HasColumnType("enum('true','false')")
                    .HasDefaultValueSql("'false'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HttpType)
                    .IsRequired()
                    .HasColumnName("http_type")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Method)
                    .IsRequired()
                    .HasColumnName("method")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MsgId)
                    .HasColumnName("msg_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("enum('true','false','running')")
                    .HasDefaultValueSql("'false'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Times)
                    .HasColumnName("times")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsCard>(entity =>
            {
                entity.HasKey(e => e.CardId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_card");

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasColumnType("tinyint(3) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CardDesc)
                    .IsRequired()
                    .HasColumnName("card_desc")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CardFee)
                    .HasColumnName("card_fee")
                    .HasColumnType("decimal(6,2) unsigned");

                entity.Property(e => e.CardImg)
                    .IsRequired()
                    .HasColumnName("card_img")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CardName)
                    .IsRequired()
                    .HasColumnName("card_name")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FreeMoney)
                    .HasColumnName("free_money")
                    .HasColumnType("decimal(6,2) unsigned");
            });

            modelBuilder.Entity<LcsCart>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_cart");

                entity.HasIndex(e => e.SessionId)
                    .HasName("session_id");

                entity.Property(e => e.RecId)
                    .HasColumnName("rec_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.CanHandsel)
                    .HasColumnName("can_handsel")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ExtensionCode)
                    .IsRequired()
                    .HasColumnName("extension_code")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsAttr)
                    .IsRequired()
                    .HasColumnName("goods_attr")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsAttrId)
                    .IsRequired()
                    .HasColumnName("goods_attr_id")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GoodsName)
                    .IsRequired()
                    .HasColumnName("goods_name")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsNumber)
                    .HasColumnName("goods_number")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.GoodsPrice)
                    .HasColumnName("goods_price")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.GoodsSn)
                    .IsRequired()
                    .HasColumnName("goods_sn")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsGift)
                    .HasColumnName("is_gift")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.IsReal)
                    .HasColumnName("is_real")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.IsShipping)
                    .HasColumnName("is_shipping")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.MarketPrice)
                    .HasColumnName("market_price")
                    .HasColumnType("decimal(10,2) unsigned");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RecType)
                    .HasColumnName("rec_type")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasColumnName("session_id")
                    .HasColumnType("char(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<LcsCatRecommend>(entity =>
            {
                entity.HasKey(e => new { e.CatId, e.RecommendType })
                    .HasName("PRIMARY");

                entity.ToTable("lcs_cat_recommend");

                entity.Property(e => e.CatId)
                    .HasColumnName("cat_id")
                    .HasColumnType("smallint(5)");

                entity.Property(e => e.RecommendType).HasColumnName("recommend_type");
            });

            modelBuilder.Entity<LcsCategory>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_category");

                entity.HasIndex(e => e.ParentId)
                    .HasName("parent_id");

                entity.Property(e => e.CatId)
                    .HasColumnName("cat_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.CatDesc)
                    .IsRequired()
                    .HasColumnName("cat_desc")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CatName)
                    .IsRequired()
                    .HasColumnName("cat_name")
                    .HasColumnType("varchar(90)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FilterAttr)
                    .IsRequired()
                    .HasColumnName("filter_attr")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Grade)
                    .HasColumnName("grade")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.IsShow)
                    .HasColumnName("is_show")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Keywords)
                    .IsRequired()
                    .HasColumnName("keywords")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MeasureUnit)
                    .IsRequired()
                    .HasColumnName("measure_unit")
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ShowInNav).HasColumnName("show_in_nav");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("sort_order")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'50'");

                entity.Property(e => e.Style)
                    .IsRequired()
                    .HasColumnName("style")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateFile)
                    .IsRequired()
                    .HasColumnName("template_file")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsCert>(entity =>
            {
                entity.ToTable("lcs_cert");

                entity.HasIndex(e => e.ConfigId)
                    .HasName("cert_config_id_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ConfigId)
                    .HasColumnName("config_id")
                    .HasColumnType("tinyint(4)")
                    .HasComment("配置id");

                entity.Property(e => e.File)
                    .IsRequired()
                    .HasColumnName("file")
                    .HasColumnType("blob");
            });

            modelBuilder.Entity<LcsCoincidence>(entity =>
            {
                entity.HasKey(e => new { e.TypeId, e.Type })
                    .HasName("PRIMARY");

                entity.ToTable("lcs_coincidence");

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<LcsCollectGoods>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_collect_goods");

                entity.HasIndex(e => e.GoodsId)
                    .HasName("goods_id");

                entity.HasIndex(e => e.IsAttention)
                    .HasName("is_attention");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.RecId)
                    .HasColumnName("rec_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsAttention).HasColumnName("is_attention");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<LcsComment>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_comment");

                entity.HasIndex(e => e.IdValue)
                    .HasName("id_value");

                entity.HasIndex(e => e.ParentId)
                    .HasName("parent_id");

                entity.Property(e => e.CommentId)
                    .HasColumnName("comment_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CommentRank)
                    .HasColumnName("comment_rank")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.CommentType)
                    .HasColumnName("comment_type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdValue)
                    .HasColumnName("id_value")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasColumnName("ip_address")
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsConfig>(entity =>
            {
                entity.ToTable("lcs_config");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Config)
                    .IsRequired()
                    .HasColumnName("config")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp");
            });

            modelBuilder.Entity<LcsCrons>(entity =>
            {
                entity.HasKey(e => e.CronId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_crons");

                entity.HasIndex(e => e.CronCode)
                    .HasName("cron_code");

                entity.HasIndex(e => e.Enable)
                    .HasName("enable");

                entity.HasIndex(e => e.Nextime)
                    .HasName("nextime");

                entity.Property(e => e.CronId)
                    .HasColumnName("cron_id")
                    .HasColumnType("tinyint(3) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AllowIp)
                    .IsRequired()
                    .HasColumnName("allow_ip")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AlowFiles)
                    .IsRequired()
                    .HasColumnName("alow_files")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CronCode)
                    .IsRequired()
                    .HasColumnName("cron_code")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CronConfig)
                    .IsRequired()
                    .HasColumnName("cron_config")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CronDesc)
                    .HasColumnName("cron_desc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CronName)
                    .IsRequired()
                    .HasColumnName("cron_name")
                    .HasColumnType("varchar(120)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CronOrder)
                    .HasColumnName("cron_order")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Day)
                    .HasColumnName("day")
                    .HasColumnType("tinyint(2)");

                entity.Property(e => e.Enable)
                    .IsRequired()
                    .HasColumnName("enable")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Hour)
                    .IsRequired()
                    .HasColumnName("hour")
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Minute)
                    .IsRequired()
                    .HasColumnName("minute")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nextime)
                    .HasColumnName("nextime")
                    .HasColumnType("int(10)");

                entity.Property(e => e.RunOnce).HasColumnName("run_once");

                entity.Property(e => e.Thistime)
                    .HasColumnName("thistime")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Week)
                    .IsRequired()
                    .HasColumnName("week")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsDeliveryGoods>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_delivery_goods");

                entity.HasIndex(e => e.GoodsId)
                    .HasName("goods_id");

                entity.HasIndex(e => new { e.DeliveryId, e.GoodsId })
                    .HasName("delivery_id");

                entity.Property(e => e.RecId)
                    .HasColumnName("rec_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.BrandName)
                    .HasColumnName("brand_name")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DeliveryId)
                    .HasColumnName("delivery_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ExtensionCode)
                    .HasColumnName("extension_code")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsAttr)
                    .HasColumnName("goods_attr")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GoodsName)
                    .HasColumnName("goods_name")
                    .HasColumnType("varchar(120)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsSn)
                    .HasColumnName("goods_sn")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsReal)
                    .HasColumnName("is_real")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProductSn)
                    .HasColumnName("product_sn")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SendNumber)
                    .HasColumnName("send_number")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<LcsDeliveryOrder>(entity =>
            {
                entity.HasKey(e => e.DeliveryId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_delivery_order");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.DeliveryId)
                    .HasColumnName("delivery_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.ActionUser)
                    .HasColumnName("action_user")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AgencyId)
                    .HasColumnName("agency_id")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BestTime)
                    .HasColumnName("best_time")
                    .HasColumnType("varchar(120)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Consignee)
                    .HasColumnName("consignee")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DeliverySn)
                    .IsRequired()
                    .HasColumnName("delivery_sn")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HowOos)
                    .HasColumnName("how_oos")
                    .HasColumnType("varchar(120)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InsureFee)
                    .HasColumnName("insure_fee")
                    .HasColumnType("decimal(10,2) unsigned")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("invoice_no")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OrderSn)
                    .IsRequired()
                    .HasColumnName("order_sn")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Postscript)
                    .HasColumnName("postscript")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ShippingFee)
                    .HasColumnName("shipping_fee")
                    .HasColumnType("decimal(10,2) unsigned")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.ShippingId)
                    .HasColumnName("shipping_id")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ShippingName)
                    .HasColumnName("shipping_name")
                    .HasColumnType("varchar(120)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SignBuilding)
                    .HasColumnName("sign_building")
                    .HasColumnType("varchar(120)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.SuppliersId)
                    .HasColumnName("suppliers_id")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsDevice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lcs_device");

                entity.HasIndex(e => e.DeviceId)
                    .HasName("device_device_id_index");

                entity.HasIndex(e => e.DeviceType)
                    .HasName("device_device_type_index");

                entity.HasIndex(e => e.PlatformType)
                    .HasName("device_platform_type_index");

                entity.HasIndex(e => e.Status)
                    .HasName("device_status_index");

                entity.HasIndex(e => e.UserId)
                    .HasName("device_user_id_unique")
                    .IsUnique();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp");

                entity.Property(e => e.DeviceId)
                    .IsRequired()
                    .HasColumnName("device_id")
                    .HasColumnType("varchar(200)")
                    .HasComment("设备id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DeviceType)
                    .IsRequired()
                    .HasColumnName("device_type")
                    .HasColumnType("varchar(200)")
                    .HasComment("设备类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlatformType)
                    .IsRequired()
                    .HasColumnName("platform_type")
                    .HasColumnType("varchar(200)")
                    .HasComment("平台类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("推送开关 0:关闭 1:开启 默认开启");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<LcsEmailList>(entity =>
            {
                entity.ToTable("lcs_email_list");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Hash)
                    .IsRequired()
                    .HasColumnName("hash")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Stat).HasColumnName("stat");
            });

            modelBuilder.Entity<LcsEmailSendlist>(entity =>
            {
                entity.ToTable("lcs_email_sendlist");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailContent)
                    .IsRequired()
                    .HasColumnName("email_content")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Error).HasColumnName("error");

                entity.Property(e => e.LastSend)
                    .HasColumnName("last_send")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Pri)
                    .HasColumnName("pri")
                    .HasColumnType("tinyint(10)");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("mediumint(8)");
            });

            modelBuilder.Entity<LcsErrorLog>(entity =>
            {
                entity.ToTable("lcs_error_log");

                entity.HasIndex(e => e.Time)
                    .HasName("time");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10)");

                entity.Property(e => e.File)
                    .IsRequired()
                    .HasColumnName("file")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasColumnName("info")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(10)");
            });

            modelBuilder.Entity<LcsExchangeGoods>(entity =>
            {
                entity.HasKey(e => e.GoodsId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_exchange_goods");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ExchangeIntegral)
                    .HasColumnName("exchange_integral")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsExchange)
                    .HasColumnName("is_exchange")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.IsHot)
                    .HasColumnName("is_hot")
                    .HasColumnType("tinyint(1) unsigned");
            });

            modelBuilder.Entity<LcsFavourableActivity>(entity =>
            {
                entity.HasKey(e => e.ActId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_favourable_activity");

                entity.HasIndex(e => e.ActName)
                    .HasName("act_name");

                entity.Property(e => e.ActId)
                    .HasColumnName("act_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ActName)
                    .IsRequired()
                    .HasColumnName("act_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ActRange)
                    .HasColumnName("act_range")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ActRangeExt)
                    .IsRequired()
                    .HasColumnName("act_range_ext")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ActType)
                    .HasColumnName("act_type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ActTypeExt)
                    .HasColumnName("act_type_ext")
                    .HasColumnType("decimal(10,2) unsigned");

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Gift)
                    .IsRequired()
                    .HasColumnName("gift")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaxAmount)
                    .HasColumnName("max_amount")
                    .HasColumnType("decimal(10,2) unsigned");

                entity.Property(e => e.MinAmount)
                    .HasColumnName("min_amount")
                    .HasColumnType("decimal(10,2) unsigned");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("sort_order")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'50'");

                entity.Property(e => e.StartTime)
                    .HasColumnName("start_time")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.UserRank)
                    .IsRequired()
                    .HasColumnName("user_rank")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsFeedback>(entity =>
            {
                entity.HasKey(e => e.MsgId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_feedback");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.MsgId)
                    .HasColumnName("msg_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.MessageImg)
                    .IsRequired()
                    .HasColumnName("message_img")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MsgArea)
                    .HasColumnName("msg_area")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.MsgContent)
                    .IsRequired()
                    .HasColumnName("msg_content")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MsgStatus)
                    .HasColumnName("msg_status")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.MsgTime)
                    .HasColumnName("msg_time")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.MsgTitle)
                    .IsRequired()
                    .HasColumnName("msg_title")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MsgType)
                    .HasColumnName("msg_type")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasColumnName("user_email")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsFriendLink>(entity =>
            {
                entity.HasKey(e => e.LinkId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_friend_link");

                entity.HasIndex(e => e.ShowOrder)
                    .HasName("show_order");

                entity.Property(e => e.LinkId)
                    .HasColumnName("link_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.LinkLogo)
                    .IsRequired()
                    .HasColumnName("link_logo")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LinkName)
                    .IsRequired()
                    .HasColumnName("link_name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LinkUrl)
                    .IsRequired()
                    .HasColumnName("link_url")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShowOrder)
                    .HasColumnName("show_order")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'50'");
            });

            modelBuilder.Entity<LcsGoods>(entity =>
            {
                entity.HasKey(e => e.GoodsId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_goods");

                entity.HasIndex(e => e.BrandId)
                    .HasName("brand_id");

                entity.HasIndex(e => e.CatId)
                    .HasName("cat_id");

                entity.HasIndex(e => e.GoodsNumber)
                    .HasName("goods_number");

                entity.HasIndex(e => e.GoodsSn)
                    .HasName("goods_sn");

                entity.HasIndex(e => e.GoodsWeight)
                    .HasName("goods_weight");

                entity.HasIndex(e => e.LastUpdate)
                    .HasName("last_update");

                entity.HasIndex(e => e.PromoteEndDate)
                    .HasName("promote_end_date");

                entity.HasIndex(e => e.PromoteStartDate)
                    .HasName("promote_start_date");

                entity.HasIndex(e => e.SortOrder)
                    .HasName("sort_order");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.BonusTypeId)
                    .HasColumnName("bonus_type_id")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.BrandId)
                    .HasColumnName("brand_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.CatId)
                    .HasColumnName("cat_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ClickCount)
                    .HasColumnName("click_count")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ExtensionCode)
                    .IsRequired()
                    .HasColumnName("extension_code")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GiveIntegral)
                    .HasColumnName("give_integral")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.GoodsBrief)
                    .IsRequired()
                    .HasColumnName("goods_brief")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsDesc)
                    .IsRequired()
                    .HasColumnName("goods_desc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsImg)
                    .IsRequired()
                    .HasColumnName("goods_img")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsName)
                    .IsRequired()
                    .HasColumnName("goods_name")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsNameStyle)
                    .IsRequired()
                    .HasColumnName("goods_name_style")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("'+'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsNumber)
                    .HasColumnName("goods_number")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GoodsSn)
                    .IsRequired()
                    .HasColumnName("goods_sn")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsThumb)
                    .IsRequired()
                    .HasColumnName("goods_thumb")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsType)
                    .HasColumnName("goods_type")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.GoodsWeight)
                    .HasColumnName("goods_weight")
                    .HasColumnType("decimal(10,3) unsigned");

                entity.Property(e => e.Integral)
                    .HasColumnName("integral")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsAloneSale)
                    .HasColumnName("is_alone_sale")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IsBest)
                    .HasColumnName("is_best")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.IsCheck)
                    .HasColumnName("is_check")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.IsDelete)
                    .HasColumnName("is_delete")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.IsHot)
                    .HasColumnName("is_hot")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.IsNew)
                    .HasColumnName("is_new")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.IsOnSale)
                    .HasColumnName("is_on_sale")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IsPromote)
                    .HasColumnName("is_promote")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.IsReal)
                    .HasColumnName("is_real")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IsShipping)
                    .HasColumnName("is_shipping")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Keywords)
                    .IsRequired()
                    .HasColumnName("keywords")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.MarketPrice)
                    .HasColumnName("market_price")
                    .HasColumnType("decimal(10,2) unsigned");

                entity.Property(e => e.OriginalImg)
                    .IsRequired()
                    .HasColumnName("original_img")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PromoteEndDate)
                    .HasColumnName("promote_end_date")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.PromotePrice)
                    .HasColumnName("promote_price")
                    .HasColumnType("decimal(10,2) unsigned");

                entity.Property(e => e.PromoteStartDate)
                    .HasColumnName("promote_start_date")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.ProviderName)
                    .IsRequired()
                    .HasColumnName("provider_name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RankIntegral)
                    .HasColumnName("rank_integral")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.SellerNote)
                    .IsRequired()
                    .HasColumnName("seller_note")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShopPrice)
                    .HasColumnName("shop_price")
                    .HasColumnType("decimal(10,2) unsigned");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("sort_order")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.SuppliersId)
                    .HasColumnName("suppliers_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.VirtualSales)
                    .HasColumnName("virtual_sales")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.WarnNumber)
                    .HasColumnName("warn_number")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<LcsGoodsActivity>(entity =>
            {
                entity.HasKey(e => e.ActId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_goods_activity");

                entity.HasIndex(e => new { e.ActName, e.ActType, e.GoodsId })
                    .HasName("act_name");

                entity.Property(e => e.ActId)
                    .HasColumnName("act_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.ActDesc)
                    .IsRequired()
                    .HasColumnName("act_desc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ActName)
                    .IsRequired()
                    .HasColumnName("act_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ActType)
                    .HasColumnName("act_type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ExtInfo)
                    .IsRequired()
                    .HasColumnName("ext_info")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.GoodsName)
                    .IsRequired()
                    .HasColumnName("goods_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsFinished)
                    .HasColumnName("is_finished")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StartTime)
                    .HasColumnName("start_time")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<LcsGoodsArticle>(entity =>
            {
                entity.HasKey(e => new { e.GoodsId, e.ArticleId, e.AdminId })
                    .HasName("PRIMARY");

                entity.ToTable("lcs_goods_article");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ArticleId)
                    .HasColumnName("article_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AdminId)
                    .HasColumnName("admin_id")
                    .HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<LcsGoodsAttr>(entity =>
            {
                entity.HasKey(e => e.GoodsAttrId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_goods_attr");

                entity.HasIndex(e => e.AttrId)
                    .HasName("attr_id");

                entity.HasIndex(e => e.GoodsId)
                    .HasName("goods_id");

                entity.Property(e => e.GoodsAttrId)
                    .HasColumnName("goods_attr_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AttrId)
                    .HasColumnName("attr_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.AttrPrice)
                    .IsRequired()
                    .HasColumnName("attr_price")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AttrValue)
                    .IsRequired()
                    .HasColumnName("attr_value")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<LcsGoodsCat>(entity =>
            {
                entity.HasKey(e => new { e.GoodsId, e.CatId })
                    .HasName("PRIMARY");

                entity.ToTable("lcs_goods_cat");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CatId)
                    .HasColumnName("cat_id")
                    .HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<LcsGoodsGallery>(entity =>
            {
                entity.HasKey(e => e.ImgId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_goods_gallery");

                entity.HasIndex(e => e.GoodsId)
                    .HasName("goods_id");

                entity.Property(e => e.ImgId)
                    .HasColumnName("img_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ImgDesc)
                    .IsRequired()
                    .HasColumnName("img_desc")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ImgOriginal)
                    .IsRequired()
                    .HasColumnName("img_original")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ImgUrl)
                    .IsRequired()
                    .HasColumnName("img_url")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ThumbUrl)
                    .IsRequired()
                    .HasColumnName("thumb_url")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsGoodsType>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_goods_type");

                entity.Property(e => e.CatId)
                    .HasColumnName("cat_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.AttrGroup)
                    .IsRequired()
                    .HasColumnName("attr_group")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CatName)
                    .IsRequired()
                    .HasColumnName("cat_name")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<LcsGroupGoods>(entity =>
            {
                entity.HasKey(e => new { e.ParentId, e.GoodsId, e.AdminId })
                    .HasName("PRIMARY");

                entity.ToTable("lcs_group_goods");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AdminId)
                    .HasColumnName("admin_id")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.GoodsPrice)
                    .HasColumnName("goods_price")
                    .HasColumnType("decimal(10,2) unsigned");
            });

            modelBuilder.Entity<LcsKeywords>(entity =>
            {
                entity.HasKey(e => new { e.Date, e.Searchengine, e.Keyword })
                    .HasName("PRIMARY");

                entity.ToTable("lcs_keywords");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Searchengine)
                    .HasColumnName("searchengine")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(90)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<LcsLinkGoods>(entity =>
            {
                entity.HasKey(e => new { e.GoodsId, e.LinkGoodsId, e.AdminId })
                    .HasName("PRIMARY");

                entity.ToTable("lcs_link_goods");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LinkGoodsId)
                    .HasColumnName("link_goods_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AdminId)
                    .HasColumnName("admin_id")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.IsDouble)
                    .HasColumnName("is_double")
                    .HasColumnType("tinyint(1) unsigned");
            });

            modelBuilder.Entity<LcsMailTemplates>(entity =>
            {
                entity.HasKey(e => e.TemplateId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_mail_templates");

                entity.HasIndex(e => e.TemplateCode)
                    .HasName("template_code")
                    .IsUnique();

                entity.HasIndex(e => e.Type)
                    .HasName("type");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("tinyint(1) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IsHtml)
                    .HasColumnName("is_html")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.LastModify)
                    .HasColumnName("last_modify")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.LastSend)
                    .HasColumnName("last_send")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.TemplateCode)
                    .IsRequired()
                    .HasColumnName("template_code")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateContent)
                    .IsRequired()
                    .HasColumnName("template_content")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateSubject)
                    .IsRequired()
                    .HasColumnName("template_subject")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsMemberPrice>(entity =>
            {
                entity.HasKey(e => e.PriceId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_member_price");

                entity.HasIndex(e => new { e.GoodsId, e.UserRank })
                    .HasName("goods_id");

                entity.Property(e => e.PriceId)
                    .HasColumnName("price_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserPrice)
                    .HasColumnName("user_price")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.UserRank)
                    .HasColumnName("user_rank")
                    .HasColumnType("tinyint(3)");
            });

            modelBuilder.Entity<LcsNav>(entity =>
            {
                entity.ToTable("lcs_nav");

                entity.HasIndex(e => e.Ifshow)
                    .HasName("ifshow");

                entity.HasIndex(e => e.Type)
                    .HasName("type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.Cid)
                    .HasColumnName("cid")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Ctype)
                    .HasColumnName("ctype")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ifshow).HasColumnName("ifshow");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Opennew).HasColumnName("opennew");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Vieworder).HasColumnName("vieworder");
            });

            modelBuilder.Entity<LcsOrderAction>(entity =>
            {
                entity.HasKey(e => e.ActionId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_order_action");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.Property(e => e.ActionId)
                    .HasColumnName("action_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.ActionNote)
                    .IsRequired()
                    .HasColumnName("action_note")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ActionPlace)
                    .HasColumnName("action_place")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.ActionUser)
                    .IsRequired()
                    .HasColumnName("action_user")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LogTime)
                    .HasColumnName("log_time")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OrderStatus)
                    .HasColumnName("order_status")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.PayStatus)
                    .HasColumnName("pay_status")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.ShippingStatus)
                    .HasColumnName("shipping_status")
                    .HasColumnType("tinyint(1) unsigned");
            });

            modelBuilder.Entity<LcsOrderGoods>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_order_goods");

                entity.HasIndex(e => e.GoodsId)
                    .HasName("goods_id");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.Property(e => e.RecId)
                    .HasColumnName("rec_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.DiscountFee)
                    .HasColumnName("discount_fee")
                    .HasColumnType("decimal(10,2)")
                    .HasComment("对接erp专用，商品优惠金额");

                entity.Property(e => e.ExtensionCode)
                    .IsRequired()
                    .HasColumnName("extension_code")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsAttr)
                    .IsRequired()
                    .HasColumnName("goods_attr")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsAttrId)
                    .IsRequired()
                    .HasColumnName("goods_attr_id")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GoodsName)
                    .IsRequired()
                    .HasColumnName("goods_name")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsNumber)
                    .HasColumnName("goods_number")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.GoodsPrice)
                    .HasColumnName("goods_price")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.GoodsSn)
                    .IsRequired()
                    .HasColumnName("goods_sn")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsGift)
                    .HasColumnName("is_gift")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.IsReal)
                    .HasColumnName("is_real")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.MarketPrice)
                    .HasColumnName("market_price")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SendNumber)
                    .HasColumnName("send_number")
                    .HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<LcsOrderInfo>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_order_info");

                entity.HasIndex(e => e.AgencyId)
                    .HasName("agency_id");

                entity.HasIndex(e => e.OrderSn)
                    .HasName("order_sn")
                    .IsUnique();

                entity.HasIndex(e => e.OrderStatus)
                    .HasName("order_status");

                entity.HasIndex(e => e.PayId)
                    .HasName("pay_id");

                entity.HasIndex(e => e.PayStatus)
                    .HasName("pay_status");

                entity.HasIndex(e => e.ShippingId)
                    .HasName("shipping_id");

                entity.HasIndex(e => e.ShippingStatus)
                    .HasName("shipping_status");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.ExtensionCode, e.ExtensionId })
                    .HasName("extension_code");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AgencyId)
                    .HasColumnName("agency_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.BestTime)
                    .IsRequired()
                    .HasColumnName("best_time")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Bonus)
                    .HasColumnName("bonus")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.BonusId)
                    .HasColumnName("bonus_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CallbackStatus)
                    .HasColumnName("callback_status")
                    .HasColumnType("enum('true','false')")
                    .HasDefaultValueSql("'true'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CardFee)
                    .HasColumnName("card_fee")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.CardMessage)
                    .IsRequired()
                    .HasColumnName("card_message")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CardName)
                    .IsRequired()
                    .HasColumnName("card_name")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ConfirmTime)
                    .HasColumnName("confirm_time")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Consignee)
                    .IsRequired()
                    .HasColumnName("consignee")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ExtensionCode)
                    .IsRequired()
                    .HasColumnName("extension_code")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ExtensionId)
                    .HasColumnName("extension_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FromAd)
                    .HasColumnName("from_ad")
                    .HasColumnType("smallint(5)");

                entity.Property(e => e.GoodsAmount)
                    .HasColumnName("goods_amount")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.GoodsDiscountFee)
                    .HasColumnName("goods_discount_fee")
                    .HasColumnType("decimal(10,2)")
                    .HasComment("对接erp专用，商品优惠总金额");

                entity.Property(e => e.HowOos)
                    .IsRequired()
                    .HasColumnName("how_oos")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HowSurplus)
                    .IsRequired()
                    .HasColumnName("how_surplus")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InsureFee)
                    .HasColumnName("insure_fee")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Integral)
                    .HasColumnName("integral")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IntegralMoney)
                    .HasColumnName("integral_money")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.InvContent)
                    .IsRequired()
                    .HasColumnName("inv_content")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InvPayee)
                    .IsRequired()
                    .HasColumnName("inv_payee")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InvType)
                    .IsRequired()
                    .HasColumnName("inv_type")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("invoice_no")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsSeparate).HasColumnName("is_separate");

                entity.Property(e => e.Lastmodify)
                    .HasColumnName("lastmodify")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasColumnName("mobile")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MoneyPaid)
                    .HasColumnName("money_paid")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.OrderAmount)
                    .HasColumnName("order_amount")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.OrderSn)
                    .IsRequired()
                    .HasColumnName("order_sn")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderStatus)
                    .HasColumnName("order_status")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.PackFee)
                    .HasColumnName("pack_fee")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.PackId)
                    .HasColumnName("pack_id")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.PackName)
                    .IsRequired()
                    .HasColumnName("pack_name")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PayFee)
                    .HasColumnName("pay_fee")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.PayId)
                    .HasColumnName("pay_id")
                    .HasColumnType("tinyint(3)");

                entity.Property(e => e.PayName)
                    .IsRequired()
                    .HasColumnName("pay_name")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayNote)
                    .IsRequired()
                    .HasColumnName("pay_note")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayStatus)
                    .HasColumnName("pay_status")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.PayTime)
                    .HasColumnName("pay_time")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Postscript)
                    .IsRequired()
                    .HasColumnName("postscript")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Referer)
                    .IsRequired()
                    .HasColumnName("referer")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShippingFee)
                    .HasColumnName("shipping_fee")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ShippingId)
                    .HasColumnName("shipping_id")
                    .HasColumnType("tinyint(3)");

                entity.Property(e => e.ShippingName)
                    .IsRequired()
                    .HasColumnName("shipping_name")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShippingStatus)
                    .HasColumnName("shipping_status")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.ShippingTime)
                    .HasColumnName("shipping_time")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.SignBuilding)
                    .IsRequired()
                    .HasColumnName("sign_building")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Surplus)
                    .HasColumnName("surplus")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Tax)
                    .HasColumnName("tax")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasColumnName("tel")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ToBuyer)
                    .IsRequired()
                    .HasColumnName("to_buyer")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Zipcode)
                    .IsRequired()
                    .HasColumnName("zipcode")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsOrderReview>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lcs_order_review");

                entity.HasIndex(e => new { e.UserId, e.OrderId, e.GoodsId })
                    .HasName("order_review_user_id_order_id_goods_id_unique")
                    .IsUnique();

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<LcsPack>(entity =>
            {
                entity.HasKey(e => e.PackId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_pack");

                entity.Property(e => e.PackId)
                    .HasColumnName("pack_id")
                    .HasColumnType("tinyint(3) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FreeMoney)
                    .HasColumnName("free_money")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.PackDesc)
                    .IsRequired()
                    .HasColumnName("pack_desc")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PackFee)
                    .HasColumnName("pack_fee")
                    .HasColumnType("decimal(6,2) unsigned");

                entity.Property(e => e.PackImg)
                    .IsRequired()
                    .HasColumnName("pack_img")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PackName)
                    .IsRequired()
                    .HasColumnName("pack_name")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsPackageGoods>(entity =>
            {
                entity.HasKey(e => new { e.PackageId, e.GoodsId, e.AdminId, e.ProductId })
                    .HasName("PRIMARY");

                entity.ToTable("lcs_package_goods");

                entity.Property(e => e.PackageId)
                    .HasColumnName("package_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AdminId)
                    .HasColumnName("admin_id")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GoodsNumber)
                    .HasColumnName("goods_number")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<LcsPayLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_pay_log");

                entity.Property(e => e.LogId)
                    .HasColumnName("log_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IsPaid)
                    .HasColumnName("is_paid")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.OrderAmount)
                    .HasColumnName("order_amount")
                    .HasColumnType("decimal(10,2) unsigned");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OrderType)
                    .HasColumnName("order_type")
                    .HasColumnType("tinyint(1) unsigned");
            });

            modelBuilder.Entity<LcsPayment>(entity =>
            {
                entity.HasKey(e => e.PayId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_payment");

                entity.HasIndex(e => e.PayCode)
                    .HasName("pay_code")
                    .IsUnique();

                entity.Property(e => e.PayId)
                    .HasColumnName("pay_id")
                    .HasColumnType("tinyint(3) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.IsCod)
                    .HasColumnName("is_cod")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.IsOnline)
                    .HasColumnName("is_online")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.PayCode)
                    .IsRequired()
                    .HasColumnName("pay_code")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayConfig)
                    .IsRequired()
                    .HasColumnName("pay_config")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayDesc)
                    .IsRequired()
                    .HasColumnName("pay_desc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayFee)
                    .IsRequired()
                    .HasColumnName("pay_fee")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayName)
                    .IsRequired()
                    .HasColumnName("pay_name")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayOrder)
                    .HasColumnName("pay_order")
                    .HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<LcsPlugins>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_plugins");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Assign)
                    .HasColumnName("assign")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.InstallDate)
                    .HasColumnName("install_date")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Library)
                    .IsRequired()
                    .HasColumnName("library")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("version")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsProducts>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_products");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.GoodsAttr)
                    .HasColumnName("goods_attr")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProductNumber)
                    .HasColumnName("product_number")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProductSn)
                    .HasColumnName("product_sn")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsPush>(entity =>
            {
                entity.ToTable("lcs_push");

                entity.HasIndex(e => e.Content)
                    .HasName("push_content_index");

                entity.HasIndex(e => e.Link)
                    .HasName("push_link_index");

                entity.HasIndex(e => e.ObjectId)
                    .HasName("push_objectid_index");

                entity.HasIndex(e => e.Photo)
                    .HasName("push_photo_index");

                entity.HasIndex(e => e.Status)
                    .HasName("push_status_index");

                entity.HasIndex(e => e.Title)
                    .HasName("push_title_index");

                entity.HasIndex(e => e.UserId)
                    .HasName("push_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("varchar(200)")
                    .HasComment("内容")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp");

                entity.Property(e => e.IsPush)
                    .HasColumnName("isPush")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("定时任务是否已经推送");

                entity.Property(e => e.Link)
                    .HasColumnName("link")
                    .HasColumnType("varchar(200)")
                    .HasComment("链接")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MessageType)
                    .HasColumnName("message_type")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("消息类型 1　系统消息 ２ 物流消息");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("objectId")
                    .HasColumnType("varchar(200)")
                    .HasComment("leancloud返回的objectId")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasColumnType("varchar(200)")
                    .HasComment("图片")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Platform)
                    .HasColumnName("platform")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'3'")
                    .HasComment("平台类型");

                entity.Property(e => e.PushAt)
                    .HasColumnName("push_at")
                    .HasColumnType("timestamp")
                    .HasComment("定时推送时间");

                entity.Property(e => e.PushType)
                    .HasColumnName("push_type")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("任务类型 1 定时任务 0 即时推送");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("状态 0:关闭 1:开启 默认开启");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(200)")
                    .HasComment("标题")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<LcsRegExtendInfo>(entity =>
            {
                entity.ToTable("lcs_reg_extend_info");

                entity.Property(e => e.Id).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RegFieldId)
                    .HasColumnName("reg_field_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("mediumint(8) unsigned");
            });

            modelBuilder.Entity<LcsRegFields>(entity =>
            {
                entity.ToTable("lcs_reg_fields");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("tinyint(3) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DisOrder)
                    .HasColumnName("dis_order")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.Display)
                    .HasColumnName("display")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IsNeed)
                    .HasColumnName("is_need")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.RegFieldName)
                    .IsRequired()
                    .HasColumnName("reg_field_name")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(1) unsigned");
            });

            modelBuilder.Entity<LcsRegion>(entity =>
            {
                entity.HasKey(e => e.RegionId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_region");

                entity.HasIndex(e => e.AgencyId)
                    .HasName("agency_id");

                entity.HasIndex(e => e.ParentId)
                    .HasName("parent_id");

                entity.HasIndex(e => e.RegionType)
                    .HasName("region_type");

                entity.Property(e => e.RegionId)
                    .HasColumnName("region_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.AgencyId)
                    .HasColumnName("agency_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RegionName)
                    .IsRequired()
                    .HasColumnName("region_name")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RegionType)
                    .IsRequired()
                    .HasColumnName("region_type")
                    .HasDefaultValueSql("'2'");
            });

            modelBuilder.Entity<LcsRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_role");

                entity.HasIndex(e => e.RoleName)
                    .HasName("user_name");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ActionList)
                    .IsRequired()
                    .HasColumnName("action_list")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RoleDescribe)
                    .HasColumnName("role_describe")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasColumnName("role_name")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsSearchHistory>(entity =>
            {
                entity.ToTable("lcs_search_history");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Keyword)
                    .IsRequired()
                    .HasColumnName("keyword")
                    .HasColumnType("char(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StoreId)
                    .HasColumnName("store_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("enum('goods','store')")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated)
                    .HasColumnName("updated")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<LcsSearchengine>(entity =>
            {
                entity.HasKey(e => new { e.Date, e.Searchengine })
                    .HasName("PRIMARY");

                entity.ToTable("lcs_searchengine");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Searchengine)
                    .HasColumnName("searchengine")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<LcsSessions>(entity =>
            {
                entity.HasKey(e => e.Sesskey)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_sessions");

                entity.HasIndex(e => e.Expiry)
                    .HasName("expiry");

                entity.Property(e => e.Sesskey)
                    .HasColumnName("sesskey")
                    .HasColumnType("char(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");

                entity.Property(e => e.Adminid)
                    .HasColumnName("adminid")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("char(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasColumnType("decimal(3,2)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Expiry)
                    .HasColumnName("expiry")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasColumnType("char(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserRank)
                    .HasColumnName("user_rank")
                    .HasColumnType("tinyint(3)");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<LcsSessionsData>(entity =>
            {
                entity.HasKey(e => e.Sesskey)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_sessions_data");

                entity.HasIndex(e => e.Expiry)
                    .HasName("expiry");

                entity.Property(e => e.Sesskey)
                    .HasColumnName("sesskey")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Expiry)
                    .HasColumnName("expiry")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<LcsShipping>(entity =>
            {
                entity.HasKey(e => e.ShippingId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_shipping");

                entity.HasIndex(e => new { e.ShippingCode, e.Enabled })
                    .HasName("shipping_code");

                entity.Property(e => e.ShippingId)
                    .HasColumnName("shipping_id")
                    .HasColumnType("tinyint(3) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ConfigLable)
                    .HasColumnName("config_lable")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Insure)
                    .IsRequired()
                    .HasColumnName("insure")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PrintBg)
                    .HasColumnName("print_bg")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PrintModel)
                    .HasColumnName("print_model")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ShippingCode)
                    .IsRequired()
                    .HasColumnName("shipping_code")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShippingDesc)
                    .IsRequired()
                    .HasColumnName("shipping_desc")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShippingName)
                    .IsRequired()
                    .HasColumnName("shipping_name")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShippingOrder)
                    .HasColumnName("shipping_order")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ShippingPrint)
                    .IsRequired()
                    .HasColumnName("shipping_print")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupportCod)
                    .HasColumnName("support_cod")
                    .HasColumnType("tinyint(1) unsigned");
            });

            modelBuilder.Entity<LcsShippingArea>(entity =>
            {
                entity.HasKey(e => e.ShippingAreaId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_shipping_area");

                entity.HasIndex(e => e.ShippingId)
                    .HasName("shipping_id");

                entity.Property(e => e.ShippingAreaId)
                    .HasColumnName("shipping_area_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Configure)
                    .IsRequired()
                    .HasColumnName("configure")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShippingAreaName)
                    .IsRequired()
                    .HasColumnName("shipping_area_name")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShippingId)
                    .HasColumnName("shipping_id")
                    .HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<LcsShopBind>(entity =>
            {
                entity.HasKey(e => e.ShopId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_shop_bind");

                entity.Property(e => e.ShopId)
                    .HasColumnName("shop_id")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.AppUrl)
                    .HasColumnName("app_url")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasComment("名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NodeId)
                    .HasColumnName("node_id")
                    .HasColumnType("varchar(32)")
                    .HasComment("节点")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NodeType)
                    .HasColumnName("node_type")
                    .HasColumnType("varchar(128)")
                    .HasComment("节点类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("enum('bind','unbind')")
                    .HasComment("状态")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsShopConfig>(entity =>
            {
                entity.ToTable("lcs_shop_config");

                entity.HasIndex(e => e.Code)
                    .HasName("code")
                    .IsUnique();

                entity.HasIndex(e => e.ParentId)
                    .HasName("parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("sort_order")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.StoreDir)
                    .IsRequired()
                    .HasColumnName("store_dir")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StoreRange)
                    .IsRequired()
                    .HasColumnName("store_range")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsSnatchLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_snatch_log");

                entity.HasIndex(e => e.SnatchId)
                    .HasName("snatch_id");

                entity.Property(e => e.LogId)
                    .HasColumnName("log_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.BidPrice)
                    .HasColumnName("bid_price")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.BidTime)
                    .HasColumnName("bid_time")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.SnatchId)
                    .HasColumnName("snatch_id")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<LcsSns>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lcs_sns");

                entity.HasIndex(e => e.OpenId)
                    .HasName("sns_open_id_index");

                entity.HasIndex(e => e.UserId)
                    .HasName("sns_user_id_unique")
                    .IsUnique();

                entity.HasIndex(e => e.Vendor)
                    .HasName("sns_vendor_index");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp");

                entity.Property(e => e.OpenId)
                    .IsRequired()
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Vendor)
                    .HasColumnName("vendor")
                    .HasColumnType("tinyint(4)")
                    .HasComment("第三方平台类型");
            });

            modelBuilder.Entity<LcsStats>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lcs_stats");

                entity.HasIndex(e => e.AccessTime)
                    .HasName("access_time");

                entity.Property(e => e.AccessTime)
                    .HasColumnName("access_time")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AccessUrl)
                    .IsRequired()
                    .HasColumnName("access_url")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasColumnName("area")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Browser)
                    .IsRequired()
                    .HasColumnName("browser")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasColumnName("ip_address")
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnName("language")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefererDomain)
                    .IsRequired()
                    .HasColumnName("referer_domain")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefererPath)
                    .IsRequired()
                    .HasColumnName("referer_path")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.System)
                    .IsRequired()
                    .HasColumnName("system")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VisitTimes)
                    .HasColumnName("visit_times")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<LcsSuppliers>(entity =>
            {
                entity.HasKey(e => e.SuppliersId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_suppliers");

                entity.Property(e => e.SuppliersId)
                    .HasColumnName("suppliers_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.IsCheck)
                    .HasColumnName("is_check")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SuppliersDesc)
                    .HasColumnName("suppliers_desc")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SuppliersName)
                    .HasColumnName("suppliers_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsTag>(entity =>
            {
                entity.HasKey(e => e.TagId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_tag");

                entity.HasIndex(e => e.GoodsId)
                    .HasName("goods_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.TagId)
                    .HasColumnName("tag_id")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TagWords)
                    .IsRequired()
                    .HasColumnName("tag_words")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<LcsTemplate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lcs_template");

                entity.HasIndex(e => e.Remarks)
                    .HasName("remarks");

                entity.HasIndex(e => e.Theme)
                    .HasName("theme");

                entity.HasIndex(e => new { e.Filename, e.Region })
                    .HasName("filename");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasColumnName("filename")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Library)
                    .IsRequired()
                    .HasColumnName("library")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'5'");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasColumnName("region")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasColumnName("remarks")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("sort_order")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Theme)
                    .IsRequired()
                    .HasColumnName("theme")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(1) unsigned");
            });

            modelBuilder.Entity<LcsTopic>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lcs_topic");

                entity.HasIndex(e => e.TopicId)
                    .HasName("topic_id");

                entity.Property(e => e.BaseStyle)
                    .HasColumnName("base_style")
                    .HasColumnType("char(6)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Css)
                    .IsRequired()
                    .HasColumnName("css")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Htmls)
                    .HasColumnName("htmls")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Intro)
                    .IsRequired()
                    .HasColumnName("intro")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Keywords)
                    .HasColumnName("keywords")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StartTime)
                    .HasColumnName("start_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Template)
                    .IsRequired()
                    .HasColumnName("template")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''''''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''''''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TitlePic)
                    .HasColumnName("title_pic")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TopicId)
                    .HasColumnName("topic_id")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TopicImg)
                    .HasColumnName("topic_img")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsUserAccount>(entity =>
            {
                entity.ToTable("lcs_user_account");

                entity.HasIndex(e => e.IsPaid)
                    .HasName("is_paid");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("int(10)");

                entity.Property(e => e.AdminNote)
                    .IsRequired()
                    .HasColumnName("admin_note")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AdminUser)
                    .IsRequired()
                    .HasColumnName("admin_user")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.IsPaid).HasColumnName("is_paid");

                entity.Property(e => e.PaidTime)
                    .HasColumnName("paid_time")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Payment)
                    .IsRequired()
                    .HasColumnName("payment")
                    .HasColumnType("varchar(90)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcessType).HasColumnName("process_type");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserNote)
                    .IsRequired()
                    .HasColumnName("user_note")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsUserAddress>(entity =>
            {
                entity.HasKey(e => e.AddressId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_user_address");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.AddressId)
                    .HasColumnName("address_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AddressName)
                    .IsRequired()
                    .HasColumnName("address_name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BestTime)
                    .IsRequired()
                    .HasColumnName("best_time")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("smallint(5)");

                entity.Property(e => e.Consignee)
                    .IsRequired()
                    .HasColumnName("consignee")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("smallint(5)");

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasColumnType("smallint(5)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasColumnName("mobile")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasColumnType("smallint(5)");

                entity.Property(e => e.SignBuilding)
                    .IsRequired()
                    .HasColumnName("sign_building")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasColumnName("tel")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Zipcode)
                    .IsRequired()
                    .HasColumnName("zipcode")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsUserBonus>(entity =>
            {
                entity.HasKey(e => e.BonusId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_user_bonus");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.BonusId)
                    .HasColumnName("bonus_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.BonusSn)
                    .HasColumnName("bonus_sn")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BonusTypeId)
                    .HasColumnName("bonus_type_id")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Emailed)
                    .HasColumnName("emailed")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UsedTime)
                    .HasColumnName("used_time")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<LcsUserFeed>(entity =>
            {
                entity.HasKey(e => e.FeedId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_user_feed");

                entity.Property(e => e.FeedId)
                    .HasColumnName("feed_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.FeedType)
                    .HasColumnName("feed_type")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsFeed)
                    .HasColumnName("is_feed")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ValueId)
                    .HasColumnName("value_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<LcsUserRank>(entity =>
            {
                entity.HasKey(e => e.RankId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_user_rank");

                entity.Property(e => e.RankId)
                    .HasColumnName("rank_id")
                    .HasColumnType("tinyint(3) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.MaxPoints)
                    .HasColumnName("max_points")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.MinPoints)
                    .HasColumnName("min_points")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RankName)
                    .IsRequired()
                    .HasColumnName("rank_name")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShowPrice)
                    .HasColumnName("show_price")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SpecialRank)
                    .HasColumnName("special_rank")
                    .HasColumnType("tinyint(1) unsigned");
            });

            modelBuilder.Entity<LcsUserRegStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lcs_user_reg_status");

                entity.Property(e => e.IsCompleted)
                    .HasColumnName("is_completed")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<LcsUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_users");

                entity.HasIndex(e => e.Email)
                    .HasName("email");

                entity.HasIndex(e => e.Flag)
                    .HasName("flag");

                entity.HasIndex(e => e.ParentId)
                    .HasName("parent_id");

                entity.HasIndex(e => e.UserName)
                    .HasName("user_name")
                    .IsUnique();

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.AddressId)
                    .HasColumnName("address_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasColumnName("alias")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Answer)
                    .IsRequired()
                    .HasColumnName("answer")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Birthday)
                    .HasColumnName("birthday")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.CreditLine)
                    .HasColumnName("credit_line")
                    .HasColumnType("decimal(10,2) unsigned");

                entity.Property(e => e.EcSalt)
                    .HasColumnName("ec_salt")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.FrozenMoney)
                    .HasColumnName("frozen_money")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.HomePhone)
                    .IsRequired()
                    .HasColumnName("home_phone")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsSpecial)
                    .HasColumnName("is_special")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.IsValidated)
                    .HasColumnName("is_validated")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LastIp)
                    .IsRequired()
                    .HasColumnName("last_ip")
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastLogin)
                    .HasColumnName("last_login")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.LastTime)
                    .HasColumnName("last_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.MobilePhone)
                    .IsRequired()
                    .HasColumnName("mobile_phone")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Msn)
                    .IsRequired()
                    .HasColumnName("msn")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OfficePhone)
                    .IsRequired()
                    .HasColumnName("office_phone")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PasswdAnswer)
                    .HasColumnName("passwd_answer")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PasswdQuestion)
                    .HasColumnName("passwd_question")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayPoints)
                    .HasColumnName("pay_points")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Qq)
                    .IsRequired()
                    .HasColumnName("qq")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasColumnName("question")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RankPoints)
                    .HasColumnName("rank_points")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RegTime)
                    .HasColumnName("reg_time")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasColumnName("salt")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.UserMoney)
                    .HasColumnName("user_money")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserRank)
                    .HasColumnName("user_rank")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.VisitCount)
                    .HasColumnName("visit_count")
                    .HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<LcsVersion>(entity =>
            {
                entity.ToTable("lcs_version");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("char(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp");

                entity.Property(e => e.Platform)
                    .HasColumnName("platform")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("char(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasColumnType("char(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsVirtualCard>(entity =>
            {
                entity.HasKey(e => e.CardId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_virtual_card");

                entity.HasIndex(e => e.CardSn)
                    .HasName("car_sn");

                entity.HasIndex(e => e.GoodsId)
                    .HasName("goods_id");

                entity.HasIndex(e => e.IsSaled)
                    .HasName("is_saled");

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.AddDate)
                    .HasColumnName("add_date")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CardPassword)
                    .IsRequired()
                    .HasColumnName("card_password")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CardSn)
                    .IsRequired()
                    .HasColumnName("card_sn")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Crc32)
                    .IsRequired()
                    .HasColumnName("crc32")
                    .HasColumnType("varchar(12)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsSaled).HasColumnName("is_saled");

                entity.Property(e => e.OrderSn)
                    .IsRequired()
                    .HasColumnName("order_sn")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsVolumePrice>(entity =>
            {
                entity.HasKey(e => new { e.PriceType, e.GoodsId, e.VolumeNumber })
                    .HasName("PRIMARY");

                entity.ToTable("lcs_volume_price");

                entity.Property(e => e.PriceType)
                    .HasColumnName("price_type")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.VolumeNumber)
                    .HasColumnName("volume_number")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.VolumePrice)
                    .HasColumnName("volume_price")
                    .HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<LcsVote>(entity =>
            {
                entity.HasKey(e => e.VoteId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_vote");

                entity.Property(e => e.VoteId)
                    .HasColumnName("vote_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.CanMulti)
                    .HasColumnName("can_multi")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.StartTime)
                    .HasColumnName("start_time")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.VoteCount)
                    .HasColumnName("vote_count")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.VoteName)
                    .IsRequired()
                    .HasColumnName("vote_name")
                    .HasColumnType("varchar(250)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LcsVoteLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_vote_log");

                entity.HasIndex(e => e.VoteId)
                    .HasName("vote_id");

                entity.Property(e => e.LogId)
                    .HasColumnName("log_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasColumnName("ip_address")
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VoteId)
                    .HasColumnName("vote_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.VoteTime)
                    .HasColumnName("vote_time")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<LcsVoteOption>(entity =>
            {
                entity.HasKey(e => e.OptionId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_vote_option");

                entity.HasIndex(e => e.VoteId)
                    .HasName("vote_id");

                entity.Property(e => e.OptionId)
                    .HasColumnName("option_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.OptionCount)
                    .HasColumnName("option_count")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.OptionName)
                    .IsRequired()
                    .HasColumnName("option_name")
                    .HasColumnType("varchar(250)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OptionOrder)
                    .HasColumnName("option_order")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.VoteId)
                    .HasColumnName("vote_id")
                    .HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<LcsWholesale>(entity =>
            {
                entity.HasKey(e => e.ActId)
                    .HasName("PRIMARY");

                entity.ToTable("lcs_wholesale");

                entity.HasIndex(e => e.GoodsId)
                    .HasName("goods_id");

                entity.Property(e => e.ActId)
                    .HasColumnName("act_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.GoodsName)
                    .IsRequired()
                    .HasColumnName("goods_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Prices)
                    .IsRequired()
                    .HasColumnName("prices")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RankIds)
                    .IsRequired()
                    .HasColumnName("rank_ids")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
