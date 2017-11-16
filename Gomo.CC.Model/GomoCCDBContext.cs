using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Gomo.CC.Model
{
    public partial class GomoCCDBContext : DbContext
    {
        public virtual DbSet<AccountPay> AccountPay { get; set; }
        public virtual DbSet<AccountReceivable> AccountReceivable { get; set; }
        public virtual DbSet<AdDetail> AdDetail { get; set; }
        public virtual DbSet<Admanage> Admanage { get; set; }
        public virtual DbSet<AdProfile> AdProfile { get; set; }
        public virtual DbSet<AuthorityPoint> AuthorityPoint { get; set; }
        public virtual DbSet<AuthorityPointLog> AuthorityPointLog { get; set; }
        public virtual DbSet<AutoMessageSet> AutoMessageSet { get; set; }
        public virtual DbSet<AutoMessageType> AutoMessageType { get; set; }
        public virtual DbSet<BestAnswerVote> BestAnswerVote { get; set; }
        public virtual DbSet<BillsPayable> BillsPayable { get; set; }
        public virtual DbSet<ConsumerAccount> ConsumerAccount { get; set; }
        public virtual DbSet<ConsumerFaviorRepairShop> ConsumerFaviorRepairShop { get; set; }
        public virtual DbSet<ConsumerProfile> ConsumerProfile { get; set; }
        public virtual DbSet<ConsumerVehicle> ConsumerVehicle { get; set; }
        public virtual DbSet<CteCityOrderList> CteCityOrderList { get; set; }
        public virtual DbSet<Faqcategory> Faqcategory { get; set; }
        public virtual DbSet<Faqlist> Faqlist { get; set; }
        public virtual DbSet<ForumCategory> ForumCategory { get; set; }
        public virtual DbSet<ForumQuestion> ForumQuestion { get; set; }
        public virtual DbSet<ForumReply> ForumReply { get; set; }
        public virtual DbSet<GoodsAnswer> GoodsAnswer { get; set; }
        public virtual DbSet<GoodsList> GoodsList { get; set; }
        public virtual DbSet<GoodsOrder> GoodsOrder { get; set; }
        public virtual DbSet<GoodsOrderRating> GoodsOrderRating { get; set; }
        public virtual DbSet<GoodsPhoto> GoodsPhoto { get; set; }
        public virtual DbSet<GoodsQuestion> GoodsQuestion { get; set; }
        public virtual DbSet<ImgFile> ImgFile { get; set; }
        public virtual DbSet<ImgServer> ImgServer { get; set; }
        public virtual DbSet<MessageNotify> MessageNotify { get; set; }
        public virtual DbSet<MessageRecord> MessageRecord { get; set; }
        public virtual DbSet<MessageType> MessageType { get; set; }
        public virtual DbSet<OrderInfo> OrderInfo { get; set; }
        public virtual DbSet<QuestionList> QuestionList { get; set; }
        public virtual DbSet<RepairConsumerProfile> RepairConsumerProfile { get; set; }
        public virtual DbSet<RepairConsumerVehicle> RepairConsumerVehicle { get; set; }
        public virtual DbSet<RepairShopAccount> RepairShopAccount { get; set; }
        public virtual DbSet<RepairShopInfo> RepairShopInfo { get; set; }
        public virtual DbSet<RepairShopInventory> RepairShopInventory { get; set; }
        public virtual DbSet<RepairShopInventoryTransaction> RepairShopInventoryTransaction { get; set; }
        public virtual DbSet<RepairShopLabor> RepairShopLabor { get; set; }
        public virtual DbSet<RepairShopLaborCategory> RepairShopLaborCategory { get; set; }
        public virtual DbSet<RepairShopLaborDefault> RepairShopLaborDefault { get; set; }
        public virtual DbSet<RepairShopLaborType> RepairShopLaborType { get; set; }
        public virtual DbSet<RepairShopPhoto> RepairShopPhoto { get; set; }
        public virtual DbSet<RepairShopRating> RepairShopRating { get; set; }
        public virtual DbSet<RepairShopSupplier> RepairShopSupplier { get; set; }
        public virtual DbSet<RepairShopUserInfo> RepairShopUserInfo { get; set; }
        public virtual DbSet<ReplyList> ReplyList { get; set; }
        public virtual DbSet<ReportCustCar> ReportCustCar { get; set; }
        public virtual DbSet<ReportCustomer> ReportCustomer { get; set; }
        public virtual DbSet<ReportCustOther> ReportCustOther { get; set; }
        public virtual DbSet<ReportCustProd> ReportCustProd { get; set; }
        public virtual DbSet<ReportCustSale> ReportCustSale { get; set; }
        public virtual DbSet<ReportCustStaff> ReportCustStaff { get; set; }
        public virtual DbSet<ReportInvRecv> ReportInvRecv { get; set; }
        public virtual DbSet<ReportOrderCar> ReportOrderCar { get; set; }
        public virtual DbSet<ReportOrderDetail> ReportOrderDetail { get; set; }
        public virtual DbSet<ReportOrderOther> ReportOrderOther { get; set; }
        public virtual DbSet<ReportOrderProd> ReportOrderProd { get; set; }
        public virtual DbSet<ReportOrderSale> ReportOrderSale { get; set; }
        public virtual DbSet<ReportOrderStaff> ReportOrderStaff { get; set; }
        public virtual DbSet<ReportOverall> ReportOverall { get; set; }
        public virtual DbSet<ReportPart> ReportPart { get; set; }
        public virtual DbSet<ReportSumary> ReportSumary { get; set; }
        public virtual DbSet<Reservation> Reservation { get; set; }
        public virtual DbSet<RoleInfo> RoleInfo { get; set; }
        public virtual DbSet<ShopAccountPayable> ShopAccountPayable { get; set; }
        public virtual DbSet<ShopPackageDetail> ShopPackageDetail { get; set; }
        public virtual DbSet<ShopPackageMain> ShopPackageMain { get; set; }
        public virtual DbSet<ShopPartsType> ShopPartsType { get; set; }
        public virtual DbSet<ShopPartsTypeCategory> ShopPartsTypeCategory { get; set; }
        public virtual DbSet<ShopPartsTypeDefault> ShopPartsTypeDefault { get; set; }
        public virtual DbSet<ShopStaffProfile> ShopStaffProfile { get; set; }
        public virtual DbSet<ShopWorkOrder> ShopWorkOrder { get; set; }
        public virtual DbSet<ShopWorkOrderHistory> ShopWorkOrderHistory { get; set; }
        public virtual DbSet<ShopWorkOrderTemp> ShopWorkOrderTemp { get; set; }
        public virtual DbSet<TechAskCategory> TechAskCategory { get; set; }
        public virtual DbSet<TechAskQuestion> TechAskQuestion { get; set; }
        public virtual DbSet<TechAskReply> TechAskReply { get; set; }
        public virtual DbSet<UserGuide> UserGuide { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<UserInfoParent> UserInfoParent { get; set; }
        public virtual DbSet<UserInfoRoleInfo> UserInfoRoleInfo { get; set; }
        public virtual DbSet<VehicleCategory> VehicleCategory { get; set; }
        public virtual DbSet<VehicleModel> VehicleModel { get; set; }
        public virtual DbSet<VehicleType> VehicleType { get; set; }
        public virtual DbSet<WebDriverAccessLog> WebDriverAccessLog { get; set; }
        public virtual DbSet<WebTwshopAccessLog> WebTwshopAccessLog { get; set; }
        public virtual DbSet<WorkOrderAsk> WorkOrderAsk { get; set; }
        public virtual DbSet<WorkOrderDetail> WorkOrderDetail { get; set; }
        public virtual DbSet<WorkOrderDetailHistory> WorkOrderDetailHistory { get; set; }
        public virtual DbSet<WorkOrderDetailTemp> WorkOrderDetailTemp { get; set; }
        public virtual DbSet<WorkOrderPhoto> WorkOrderPhoto { get; set; }
        public virtual DbSet<WorkOrderPhotoHistory> WorkOrderPhotoHistory { get; set; }
        public virtual DbSet<WorkOrderPhotoTemp> WorkOrderPhotoTemp { get; set; }
        public virtual DbSet<WorkOrderRating> WorkOrderRating { get; set; }

        public GomoCCDBContext(DbContextOptions<GomoCCDBContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountPay>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bank).HasMaxLength(50);

                entity.Property(e => e.BankAccount).HasMaxLength(50);

                entity.Property(e => e.CheckNumber).HasMaxLength(50);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(50);

                entity.Property(e => e.PaymentMethod).HasColumnType("int(11)");

                entity.Property(e => e.PaymentTerms).HasColumnType("int(11)");

                entity.Property(e => e.RepairShopInfoId)
                    .HasColumnName("RepairShopInfo_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SuppilerName).HasMaxLength(50);

                entity.Property(e => e.Total).HasColumnType("char(10)");
            });

            modelBuilder.Entity<AccountReceivable>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Balance).HasColumnType("decimal(18,0)");

                entity.Property(e => e.Note).HasMaxLength(100);

                entity.Property(e => e.Paid).HasColumnType("decimal(18,0)");

                entity.Property(e => e.Payer).HasMaxLength(50);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentMethod).HasColumnType("int(11)");

                entity.Property(e => e.ReceivableDate).HasColumnType("datetime");

                entity.Property(e => e.Settle).HasColumnType("tinyint(1)");

                entity.Property(e => e.ShopWorkOrderHistoryId)
                    .HasColumnName("ShopWorkOrderHistory_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SubTotabl).HasColumnType("decimal(18,0)");

                entity.Property(e => e.Tax).HasColumnType("decimal(18,0)");

                entity.Property(e => e.Total).HasColumnType("decimal(18,0)");
            });

            modelBuilder.Entity<AdDetail>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdProfileId)
                    .HasColumnName("AdProfile_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BannerType).HasColumnType("int(11)");

                entity.Property(e => e.IsOnline).HasColumnType("tinyint(1)");

                entity.Property(e => e.PlayEndDate).HasColumnType("datetime");

                entity.Property(e => e.PlayStartDate).HasColumnType("datetime");

                entity.Property(e => e.Url).HasMaxLength(128);
            });

            modelBuilder.Entity<Admanage>(entity =>
            {
                entity.ToTable("ADManage");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.Adname)
                    .IsRequired()
                    .HasColumnName("ADName")
                    .HasMaxLength(50);

                entity.Property(e => e.Adstatus)
                    .HasColumnName("ADStatus")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Adtype)
                    .HasColumnName("ADType")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Adurl)
                    .IsRequired()
                    .HasColumnName("ADUrl")
                    .HasMaxLength(50);

                entity.Property(e => e.AiId)
                    .HasColumnName("AI_Id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<AdProfile>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DelFlag).HasColumnType("int(11)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Paid).HasColumnType("tinyint(1)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TimeTern).HasColumnType("int(11)");

                entity.Property(e => e.UserInfoId)
                    .HasColumnName("UserInfo_Id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<AuthorityPoint>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuthorityPoint1)
                    .HasColumnName("Authority_Point")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.UserInfoId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<AuthorityPointLog>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuthorityPoint)
                    .HasColumnName("Authority_Point")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description).HasMaxLength(128);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ParentId).HasColumnType("int(11)");

                entity.Property(e => e.UserInfoId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<AutoMessageSet>(entity =>
            {
                entity.HasIndex(e => e.MessageType)
                    .HasName("MessageType");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExpiredDays).HasColumnType("int(11)");

                entity.Property(e => e.MediaTypeLine)
                    .HasColumnName("MediaType_Line")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MediaTypeMessenger)
                    .HasColumnName("MediaType_Messenger")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MediaTypeSms)
                    .HasColumnName("MediaType_SMS")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MediaTypeWechat)
                    .HasColumnName("MediaType_Wechat")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MessageContent)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.MessageType).HasColumnType("int(11)");

                entity.Property(e => e.RsaId)
                    .HasColumnName("RSA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.HasOne(d => d.MessageTypeNavigation)
                    .WithMany(p => p.AutoMessageSet)
                    .HasForeignKey(d => d.MessageType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AutoMessageSet_ibfk_1");
            });

            modelBuilder.Entity<AutoMessageType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.MessageType).HasMaxLength(50);
            });

            modelBuilder.Entity<BestAnswerVote>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.RsaId)
                    .HasColumnName("RSA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SsaId)
                    .HasColumnName("SSA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TaqId)
                    .HasColumnName("TAQ_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TarId)
                    .HasColumnName("TAR_Id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<BillsPayable>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId)
                    .HasColumnName("Account_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountName)
                    .HasColumnName("Account_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.BillsAmount)
                    .HasColumnName("Bills_Amount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BillsId)
                    .HasColumnName("Bills_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.ExchangeDate)
                    .HasColumnName("Exchange_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Payable).HasColumnType("int(11)");
            });

            modelBuilder.Entity<ConsumerAccount>(entity =>
            {
                entity.HasIndex(e => e.RsaId)
                    .HasName("RSA_Id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConsumerId)
                    .HasColumnName("ConsumerID")
                    .HasMaxLength(50);

                entity.Property(e => e.ErrorCnt).HasColumnType("int(11)");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.RsaId)
                    .HasColumnName("RSA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status).HasColumnType("int(11)");

                entity.HasOne(d => d.Rsa)
                    .WithMany(p => p.ConsumerAccount)
                    .HasForeignKey(d => d.RsaId)
                    .HasConstraintName("ConsumerAccount_ibfk_1");
            });

            modelBuilder.Entity<ConsumerFaviorRepairShop>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsFavior).HasColumnType("tinyint(1)");

                entity.Property(e => e.IsMember).HasColumnType("tinyint(1)");

                entity.Property(e => e.RepairShopInfoId)
                    .HasColumnName("RepairShopInfo_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserInfoId)
                    .HasColumnName("UserInfo_Id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ConsumerProfile>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address1).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.Address3).HasMaxLength(50);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.CaId)
                    .HasColumnName("CA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cellphone).HasMaxLength(50);

                entity.Property(e => e.ConsumerName).HasMaxLength(50);

                entity.Property(e => e.ConsumerType).HasColumnType("int(11)");

                entity.Property(e => e.Discount).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fburl)
                    .HasColumnName("FBUrl")
                    .HasMaxLength(50);

                entity.Property(e => e.Gender).HasColumnType("tinyint(1)");

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .HasMaxLength(50);

                entity.Property(e => e.PayTypeAccount)
                    .HasColumnName("PayType_Account")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.PayTypeCash)
                    .HasColumnName("PayType_Cash")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.PayTypeCheck)
                    .HasColumnName("PayType_Check")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.PayTypeCredit)
                    .HasColumnName("PayType_Credit")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.PayTypeDebit)
                    .HasColumnName("PayType_Debit")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.PayTypeMasterCard)
                    .HasColumnName("PayType_MasterCard")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Referralentry).HasMaxLength(50);

                entity.Property(e => e.Sms)
                    .HasColumnName("SMS")
                    .HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.Property(e => e.UserInfoId)
                    .HasColumnName("UserInfo_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WechatId)
                    .HasColumnName("WechatID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ConsumerVehicle>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CaId)
                    .HasColumnName("CA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.CurrentLicenseDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfManufcture).HasColumnType("datetime");

                entity.Property(e => e.ImgUrl).HasMaxLength(512);

                entity.Property(e => e.InsuranceExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.LicensePlateNumber).HasMaxLength(50);

                entity.Property(e => e.Milage).HasMaxLength(50);

                entity.Property(e => e.NextMaintainMileage).HasMaxLength(50);

                entity.Property(e => e.UserInfoId)
                    .HasColumnName("UserInfo_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VcId)
                    .HasColumnName("VC_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VmId)
                    .HasColumnName("VM_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VtId)
                    .HasColumnName("VT_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Year).HasMaxLength(50);
            });

            modelBuilder.Entity<CteCityOrderList>(entity =>
            {
                entity.HasKey(e => e.Pk);

                entity.ToTable("cteCityOrderList");

                entity.Property(e => e.Pk)
                    .HasColumnName("pk")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Faqcategory>(entity =>
            {
                entity.ToTable("FAQCategory");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<Faqlist>(entity =>
            {
                entity.ToTable("FAQList");

                entity.HasIndex(e => e.FaqcId)
                    .HasName("FAQC_Id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Content).HasMaxLength(500);

                entity.Property(e => e.FaqcId)
                    .HasColumnName("FAQC_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.Faqc)
                    .WithMany(p => p.Faqlist)
                    .HasForeignKey(d => d.FaqcId)
                    .HasConstraintName("FAQList_ibfk_1");
            });

            modelBuilder.Entity<ForumCategory>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<ForumQuestion>(entity =>
            {
                entity.HasIndex(e => e.FcId)
                    .HasName("FC_Id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId)
                    .HasColumnName("Account_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Content).HasMaxLength(50);

                entity.Property(e => e.FcId)
                    .HasColumnName("FC_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Role).HasColumnType("int(11)");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.ViewCount).HasColumnType("int(11)");

                entity.HasOne(d => d.Fc)
                    .WithMany(p => p.ForumQuestion)
                    .HasForeignKey(d => d.FcId)
                    .HasConstraintName("ForumQuestion_ibfk_1");
            });

            modelBuilder.Entity<ForumReply>(entity =>
            {
                entity.HasIndex(e => e.FqId)
                    .HasName("FQ_Id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId)
                    .HasColumnName("Account_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Content).HasMaxLength(100);

                entity.Property(e => e.FqId)
                    .HasColumnName("FQ_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Role).HasColumnType("int(11)");

                entity.HasOne(d => d.Fq)
                    .WithMany(p => p.ForumReply)
                    .HasForeignKey(d => d.FqId)
                    .HasConstraintName("ForumReply_ibfk_1");
            });

            modelBuilder.Entity<GoodsAnswer>(entity =>
            {
                entity.HasIndex(e => e.GqId)
                    .HasName("GQ_Id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Content).HasMaxLength(50);

                entity.Property(e => e.GqId)
                    .HasColumnName("GQ_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Gq)
                    .WithMany(p => p.GoodsAnswer)
                    .HasForeignKey(d => d.GqId)
                    .HasConstraintName("GoodsAnswer_ibfk_1");
            });

            modelBuilder.Entity<GoodsList>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.DealInformation).HasMaxLength(50);

                entity.Property(e => e.DelFlag).HasColumnType("int(11)");

                entity.Property(e => e.GoodsDescription).HasMaxLength(50);

                entity.Property(e => e.GoodsName).HasColumnType("char(20)");

                entity.Property(e => e.GoolsName).HasColumnType("datetime");

                entity.Property(e => e.Qty).HasColumnType("int(11)");

                entity.Property(e => e.RsaId)
                    .HasColumnName("RSA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RsiId)
                    .HasColumnName("RSI_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status).HasColumnType("int(11)");

                entity.Property(e => e.ViewCount).HasColumnType("int(11)");
            });

            modelBuilder.Entity<GoodsOrder>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Order).HasColumnType("tinyint(1)");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.Pay).HasColumnType("tinyint(1)");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.RsaId)
                    .HasColumnName("RSA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Rules).HasMaxLength(50);

                entity.Property(e => e.Ship).HasColumnType("tinyint(1)");

                entity.Property(e => e.ShipDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<GoodsOrderRating>(entity =>
            {
                entity.HasIndex(e => e.GlId)
                    .HasName("GL_Id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.GlId)
                    .HasColumnName("GL_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GoId)
                    .HasColumnName("Go_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Rating).HasColumnType("char(10)");

                entity.HasOne(d => d.Gl)
                    .WithMany(p => p.GoodsOrderRating)
                    .HasForeignKey(d => d.GlId)
                    .HasConstraintName("GoodsOrderRating_ibfk_1");
            });

            modelBuilder.Entity<GoodsPhoto>(entity =>
            {
                entity.HasIndex(e => e.GlId)
                    .HasName("GL_Id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.GlId)
                    .HasColumnName("GL_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImgUrl).HasMaxLength(512);

                entity.HasOne(d => d.Gl)
                    .WithMany(p => p.GoodsPhoto)
                    .HasForeignKey(d => d.GlId)
                    .HasConstraintName("GoodsPhoto_ibfk_1");
            });

            modelBuilder.Entity<GoodsQuestion>(entity =>
            {
                entity.HasIndex(e => e.GlId)
                    .HasName("GL_Id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Content).HasMaxLength(50);

                entity.Property(e => e.GlId)
                    .HasColumnName("GL_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RsaId)
                    .HasColumnName("RSA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.Gl)
                    .WithMany(p => p.GoodsQuestion)
                    .HasForeignKey(d => d.GlId)
                    .HasConstraintName("GoodsQuestion_ibfk_1");
            });

            modelBuilder.Entity<ImgFile>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.PathFileName).HasMaxLength(128);

                entity.Property(e => e.ServerId)
                    .HasColumnName("Server_Id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ImgServer>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Account).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Path).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasColumnName("ServerIP")
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasColumnType("int(11)");
            });

            modelBuilder.Entity<MessageNotify>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.DelFlag).HasColumnType("int(11)");

                entity.Property(e => e.DestId)
                    .HasColumnName("Dest_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExpTime).HasColumnType("datetime");

                entity.Property(e => e.IsRead).HasColumnType("tinyint(1)");

                entity.Property(e => e.IsSend).HasColumnType("tinyint(1)");

                entity.Property(e => e.MesTypeId)
                    .HasColumnName("MesType_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReservationId)
                    .HasColumnName("Reservation_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SendId)
                    .HasColumnName("Send_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SubTime).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<MessageRecord>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CaId)
                    .HasColumnName("CA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MediaType).HasColumnType("int(11)");

                entity.Property(e => e.MessageContent).HasMaxLength(50);

                entity.Property(e => e.MessageType).HasColumnType("int(11)");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.RsaId)
                    .HasColumnName("RSA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Success).HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<MessageType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.MessageEnum).HasMaxLength(32);

                entity.Property(e => e.MessageName).HasMaxLength(50);
            });

            modelBuilder.Entity<OrderInfo>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Content).HasMaxLength(64);

                entity.Property(e => e.UserInfoId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<QuestionList>(entity =>
            {
                entity.HasIndex(e => e.FaqcId)
                    .HasName("FAQC_Id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId)
                    .HasColumnName("Account_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Answer).HasColumnType("int(11)");

                entity.Property(e => e.Content).HasMaxLength(50);

                entity.Property(e => e.FaqcId)
                    .HasColumnName("FAQC_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Role).HasColumnType("int(11)");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.Faqc)
                    .WithMany(p => p.QuestionList)
                    .HasForeignKey(d => d.FaqcId)
                    .HasConstraintName("QuestionList_ibfk_1");
            });

            modelBuilder.Entity<RepairConsumerProfile>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address1).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.Address3).HasMaxLength(50);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.CaId)
                    .HasColumnName("CA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cellphone).HasMaxLength(50);

                entity.Property(e => e.ConsumerId)
                    .HasColumnName("ConsumerID")
                    .HasMaxLength(50);

                entity.Property(e => e.ConsumerName).HasMaxLength(50);

                entity.Property(e => e.ConsumerProfileId)
                    .HasColumnName("ConsumerProfile_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConsumerType).HasColumnType("int(11)");

                entity.Property(e => e.Discount).HasMaxLength(50);

                entity.Property(e => e.Driver).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fburl)
                    .HasColumnName("FBUrl")
                    .HasMaxLength(50);

                entity.Property(e => e.Gender).HasColumnType("int(11)");

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .HasMaxLength(50);

                entity.Property(e => e.PayTypeAccount)
                    .HasColumnName("PayType_Account")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.PayTypeCash)
                    .HasColumnName("PayType_Cash")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.PayTypeCheck)
                    .HasColumnName("PayType_Check")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.PayTypeCredit)
                    .HasColumnName("PayType_Credit")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.PayTypeDebit)
                    .HasColumnName("PayType_Debit")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.PayTypeMasterCard)
                    .HasColumnName("PayType_MasterCard")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Quota).HasMaxLength(50);

                entity.Property(e => e.Referralentry).HasMaxLength(50);

                entity.Property(e => e.RepairShopInfoId)
                    .HasColumnName("RepairShopInfo_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Sms)
                    .HasColumnName("SMS")
                    .HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.Property(e => e.UsedQuota).HasMaxLength(50);

                entity.Property(e => e.WechatId)
                    .HasColumnName("WechatID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RepairConsumerVehicle>(entity =>
            {
                entity.HasIndex(e => e.RcpId)
                    .HasName("RCP_Id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.DateOfManufcture).HasColumnType("datetime");

                entity.Property(e => e.ImgUrl).HasMaxLength(512);

                entity.Property(e => e.InspectionDate).HasColumnType("datetime");

                entity.Property(e => e.InsuranceExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.LicensePlateNumber).HasMaxLength(50);

                entity.Property(e => e.Milage).HasMaxLength(50);

                entity.Property(e => e.NextMaintainMileage).HasMaxLength(50);

                entity.Property(e => e.OnChange).HasColumnType("tinyint(1)");

                entity.Property(e => e.RcpId)
                    .HasColumnName("RCP_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VcId)
                    .HasColumnName("VC_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VmId)
                    .HasColumnName("VM_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VtId)
                    .HasColumnName("VT_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Year).HasMaxLength(50);

                entity.HasOne(d => d.Rcp)
                    .WithMany(p => p.RepairConsumerVehicle)
                    .HasForeignKey(d => d.RcpId)
                    .HasConstraintName("RepairConsumerVehicle_ibfk_1");
            });

            modelBuilder.Entity<RepairShopAccount>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AaiId)
                    .HasColumnName("AAI_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AccountNo).HasMaxLength(50);

                entity.Property(e => e.EndDate)
                    .HasColumnName("End_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Rank).HasColumnType("int(11)");

                entity.Property(e => e.Role).HasColumnType("int(11)");

                entity.Property(e => e.StartDate)
                    .HasColumnName("Start_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status).HasColumnType("int(11)");
            });

            modelBuilder.Entity<RepairShopInfo>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.BusinessTime).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FbUrl).HasMaxLength(512);

                entity.Property(e => e.GooglemapGeocoding).HasColumnName("googlemap_geocoding");

                entity.Property(e => e.GooglemapGeocodingIsDirty)
                    .HasColumnName("googlemap_geocoding_is_dirty")
                    .HasColumnType("char(1)");

                entity.Property(e => e.LineId).HasMaxLength(50);

                entity.Property(e => e.MaintenanceItems).HasMaxLength(512);

                entity.Property(e => e.MaintenanceProject).HasMaxLength(512);

                entity.Property(e => e.Principal).HasMaxLength(50);

                entity.Property(e => e.ShopImgUrl)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.ShopName).HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.Property(e => e.Vatnumber)
                    .HasColumnName("VATNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Wechat).HasMaxLength(50);
            });

            modelBuilder.Entity<RepairShopInventory>(entity =>
            {
                entity.HasIndex(e => e.PoNo)
                    .HasName("PO_NO");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DelFlag).HasColumnType("int(11)");

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("Expire_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PackageUnit).HasColumnType("int(11)");

                entity.Property(e => e.Paid).HasColumnType("tinyint(1)");

                entity.Property(e => e.PartName).HasMaxLength(50);

                entity.Property(e => e.PartNo)
                    .HasColumnName("PartNO")
                    .HasMaxLength(50);

                entity.Property(e => e.PartsTypeIsDefault).HasColumnType("tinyint(1)");

                entity.Property(e => e.PoDate)
                    .HasColumnName("PO_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PoNo)
                    .HasColumnName("PO_NO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PoQty)
                    .HasColumnName("PO_Qty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RepairShopInfoId)
                    .HasColumnName("RepairShopInfo_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SafeQty)
                    .HasColumnName("Safe_Qty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShopPartsTypeId)
                    .HasColumnName("ShopPartsType_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StockQty)
                    .HasColumnName("Stock_Qty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Vendor).HasColumnType("int(11)");

                entity.HasOne(d => d.PoNoNavigation)
                    .WithMany(p => p.RepairShopInventory)
                    .HasForeignKey(d => d.PoNo)
                    .HasConstraintName("RepairShopInventory_ibfk_1");
            });

            modelBuilder.Entity<RepairShopInventoryTransaction>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Method)
                    .IsRequired()
                    .HasColumnName("method")
                    .HasColumnType("char(1)");

                entity.Property(e => e.OpPrice)
                    .HasColumnName("op_price")
                    .HasColumnType("decimal(18,4)");

                entity.Property(e => e.OpQty)
                    .HasColumnName("op_qty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OpTime)
                    .HasColumnName("op_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.RefFormId)
                    .HasColumnName("ref_form_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RefFormNote)
                    .HasColumnName("ref_form_note")
                    .HasMaxLength(100);

                entity.Property(e => e.RefFormType)
                    .HasColumnName("ref_form_type")
                    .HasMaxLength(20);

                entity.Property(e => e.RepairShopInfoId)
                    .HasColumnName("RepairShopInfo_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RepairShopInventoryId)
                    .HasColumnName("RepairShopInventory_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<RepairShopLabor>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DelFlag).HasColumnType("int(11)");

                entity.Property(e => e.IsDefault).HasColumnType("tinyint(1)");

                entity.Property(e => e.LaborType).HasColumnType("int(11)");

                entity.Property(e => e.Qty)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RepairShopInfoId)
                    .HasColumnName("RepairShopInfo_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceItems).HasMaxLength(128);
            });

            modelBuilder.Entity<RepairShopLaborCategory>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LaborType).HasMaxLength(50);
            });

            modelBuilder.Entity<RepairShopLaborDefault>(entity =>
            {
                entity.HasIndex(e => e.RepairShopLaborCategoryId)
                    .HasName("RepairShopLaborCategory_Id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LaborTypeNo)
                    .HasColumnName("LaborTypeNO")
                    .HasMaxLength(50);

                entity.Property(e => e.Qty)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RepairShopLaborCategoryId)
                    .HasColumnName("RepairShopLaborCategory_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceItems).HasMaxLength(128);

                entity.Property(e => e.ServiceItemsEn).HasMaxLength(128);

                entity.HasOne(d => d.RepairShopLaborCategory)
                    .WithMany(p => p.RepairShopLaborDefault)
                    .HasForeignKey(d => d.RepairShopLaborCategoryId)
                    .HasConstraintName("RepairShopLaborDefault_ibfk_1");
            });

            modelBuilder.Entity<RepairShopLaborType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DelFlag).HasColumnType("int(11)");

                entity.Property(e => e.RepairShopInfoId)
                    .HasColumnName("RepairShopInfo_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RepairShopLaborCategoryId)
                    .HasColumnName("RepairShopLaborCategory_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceItems).HasMaxLength(50);
            });

            modelBuilder.Entity<RepairShopPhoto>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DeleteStatus).HasColumnType("tinyint(1)");

                entity.Property(e => e.RepairShopInfoId)
                    .HasColumnName("RepairShopInfo_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceImgUrl).HasMaxLength(512);
            });

            modelBuilder.Entity<RepairShopRating>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.RepairShopInfoId)
                    .HasColumnName("RepairShopInfo_Id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<RepairShopSupplier>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address1).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.Address3).HasMaxLength(50);

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.DelFlag).HasColumnType("int(11)");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Paymentterm)
                    .HasColumnName("paymentterm")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RepairShopInfoId)
                    .HasColumnName("RepairShopInfo_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShopPartsTypeId)
                    .HasColumnName("ShopPartsType_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SupplierName).HasMaxLength(50);

                entity.Property(e => e.SupplierNo)
                    .HasColumnName("SupplierNO")
                    .HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(20);

                entity.Property(e => e.VatNumber)
                    .HasColumnName("VAT_Number")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RepairShopUserInfo>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RepairShopInfoId)
                    .HasColumnName("RepairShopInfo_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserInfoId)
                    .HasColumnName("UserInfo_Id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ReplyList>(entity =>
            {
                entity.HasIndex(e => e.QlId)
                    .HasName("QL_Id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Content).HasMaxLength(50);

                entity.Property(e => e.QlId)
                    .HasColumnName("QL_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SmaId)
                    .HasColumnName("SMA_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Ql)
                    .WithMany(p => p.ReplyList)
                    .HasForeignKey(d => d.QlId)
                    .HasConstraintName("ReplyList_ibfk_1");
            });

            modelBuilder.Entity<ReportCustCar>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Balance).HasColumnType("int(11)");

                entity.Property(e => e.CarName).HasMaxLength(50);

                entity.Property(e => e.ConsumerName).HasMaxLength(50);

                entity.Property(e => e.Cost).HasColumnType("int(11)");

                entity.Property(e => e.DateOut).HasColumnType("datetime");

                entity.Property(e => e.Disc).HasColumnType("int(11)");

                entity.Property(e => e.HourPay).HasColumnType("int(11)");

                entity.Property(e => e.LaborAmt)
                    .HasColumnName("Labor_Amt")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LicensePlateNumber).HasMaxLength(50);

                entity.Property(e => e.PartAmt)
                    .HasColumnName("Part_Amt")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Profit).HasColumnType("int(11)");

                entity.Property(e => e.RswoId)
                    .HasColumnName("RSWO_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Salary).HasColumnType("int(11)");

                entity.Property(e => e.StaffName).HasMaxLength(50);

                entity.Property(e => e.Tax).HasColumnType("int(11)");

                entity.Property(e => e.WorkOrderNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportCustomer>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Balance).HasColumnType("int(11)");

                entity.Property(e => e.CarName).HasMaxLength(50);

                entity.Property(e => e.ConsumerName).HasMaxLength(50);

                entity.Property(e => e.Cost).HasColumnType("int(11)");

                entity.Property(e => e.DateOut).HasColumnType("datetime");

                entity.Property(e => e.Disc).HasColumnType("int(11)");

                entity.Property(e => e.HourPay).HasColumnType("int(11)");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.LaborAmt)
                    .HasColumnName("Labor_Amt")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LicensePlateNumber).HasMaxLength(50);

                entity.Property(e => e.PartAmt)
                    .HasColumnName("Part_Amt")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PaymentType).HasColumnType("int(11)");

                entity.Property(e => e.Profit).HasColumnType("int(11)");

                entity.Property(e => e.RswoId)
                    .HasColumnName("RSWO_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Salary).HasColumnType("int(11)");

                entity.Property(e => e.StaffName).HasMaxLength(50);

                entity.Property(e => e.Tax).HasColumnType("int(11)");

                entity.Property(e => e.WorkOrderNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportCustOther>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Balance).HasColumnType("int(11)");

                entity.Property(e => e.CarName).HasMaxLength(50);

                entity.Property(e => e.ConsumerName).HasMaxLength(50);

                entity.Property(e => e.Cost).HasColumnType("int(11)");

                entity.Property(e => e.DateOut).HasColumnType("datetime");

                entity.Property(e => e.Disc).HasColumnType("int(11)");

                entity.Property(e => e.HourPay).HasColumnType("int(11)");

                entity.Property(e => e.LaborAmt)
                    .HasColumnName("Labor_Amt")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LicensePlateNumber).HasMaxLength(50);

                entity.Property(e => e.PartAmt)
                    .HasColumnName("Part_Amt")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Profit).HasColumnType("int(11)");

                entity.Property(e => e.RswoId)
                    .HasColumnName("RSWO_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Salary).HasColumnType("int(11)");

                entity.Property(e => e.StaffName).HasMaxLength(50);

                entity.Property(e => e.Tax).HasColumnType("int(11)");

                entity.Property(e => e.WorkOrderNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportCustProd>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Balance).HasColumnType("int(11)");

                entity.Property(e => e.CarName).HasMaxLength(50);

                entity.Property(e => e.ConsumerName).HasMaxLength(50);

                entity.Property(e => e.Cost).HasColumnType("int(11)");

                entity.Property(e => e.DateOut).HasColumnType("datetime");

                entity.Property(e => e.Disc).HasColumnType("int(11)");

                entity.Property(e => e.HourPay).HasColumnType("int(11)");

                entity.Property(e => e.LaborAmt)
                    .HasColumnName("Labor_Amt")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LicensePlateNumber).HasMaxLength(50);

                entity.Property(e => e.PartAmt)
                    .HasColumnName("Part_Amt")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Profit).HasColumnType("int(11)");

                entity.Property(e => e.RswoId)
                    .HasColumnName("RSWO_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Salary).HasColumnType("int(11)");

                entity.Property(e => e.StaffName).HasMaxLength(50);

                entity.Property(e => e.Tax).HasColumnType("int(11)");

                entity.Property(e => e.WorkOrderNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportCustSale>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Balance).HasColumnType("int(11)");

                entity.Property(e => e.CarName).HasMaxLength(50);

                entity.Property(e => e.ConsumerName).HasMaxLength(50);

                entity.Property(e => e.Cost).HasColumnType("int(11)");

                entity.Property(e => e.DateOut).HasColumnType("datetime");

                entity.Property(e => e.Disc).HasColumnType("int(11)");

                entity.Property(e => e.HourPay).HasColumnType("int(11)");

                entity.Property(e => e.LaborAmt)
                    .HasColumnName("Labor_Amt")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LicensePlateNumber).HasMaxLength(50);

                entity.Property(e => e.PartAmt)
                    .HasColumnName("Part_Amt")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Profit).HasColumnType("int(11)");

                entity.Property(e => e.RswoId)
                    .HasColumnName("RSWO_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Salary).HasColumnType("int(11)");

                entity.Property(e => e.StaffName).HasMaxLength(50);

                entity.Property(e => e.Tax).HasColumnType("int(11)");

                entity.Property(e => e.WorkOrderNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportCustStaff>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Balance).HasColumnType("int(11)");

                entity.Property(e => e.CarName).HasMaxLength(50);

                entity.Property(e => e.ConsumerName).HasMaxLength(50);

                entity.Property(e => e.Cost).HasColumnType("int(11)");

                entity.Property(e => e.DateOut).HasColumnType("datetime");

                entity.Property(e => e.Disc).HasColumnType("int(11)");

                entity.Property(e => e.HourPay).HasColumnType("int(11)");

                entity.Property(e => e.LaborAmt)
                    .HasColumnName("Labor_Amt")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LicensePlateNumber).HasMaxLength(50);

                entity.Property(e => e.PartAmt)
                    .HasColumnName("Part_Amt")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Profit).HasColumnType("int(11)");

                entity.Property(e => e.RswoId)
                    .HasColumnName("RSWO_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Salary).HasColumnType("int(11)");

                entity.Property(e => e.StaffName).HasMaxLength(50);

                entity.Property(e => e.Tax).HasColumnType("int(11)");

                entity.Property(e => e.WorkOrderNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportInvRecv>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Balance).HasColumnType("int(11)");

                entity.Property(e => e.CaId)
                    .HasColumnName("CA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConsumerName).HasMaxLength(50);

                entity.Property(e => e.DateOut).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentType).HasColumnType("int(11)");

                entity.Property(e => e.RswoId)
                    .HasColumnName("RSWO_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tax).HasColumnType("int(11)");

                entity.Property(e => e.WorkOrderNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportOrderCar>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cost).HasColumnType("int(11)");

                entity.Property(e => e.Disc).HasColumnType("int(11)");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("Goods_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Profit).HasColumnType("int(11)");

                entity.Property(e => e.Qty).HasColumnType("int(11)");

                entity.Property(e => e.Sell).HasColumnType("int(11)");

                entity.Property(e => e.SpmId)
                    .HasColumnName("SPM_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SwoId)
                    .HasColumnName("SWO_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tax).HasColumnType("int(11)");

                entity.Property(e => e.Total).HasColumnType("int(11)");

                entity.Property(e => e.Type).HasColumnType("int(11)");
            });

            modelBuilder.Entity<ReportOrderDetail>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cost).HasColumnType("int(11)");

                entity.Property(e => e.Disc).HasColumnType("int(11)");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("Goods_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Profit).HasColumnType("int(11)");

                entity.Property(e => e.Qty).HasColumnType("int(11)");

                entity.Property(e => e.Sell).HasColumnType("int(11)");

                entity.Property(e => e.SpmId)
                    .HasColumnName("SPM_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SwoId)
                    .HasColumnName("SWO_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tax).HasColumnType("int(11)");

                entity.Property(e => e.Total).HasColumnType("int(11)");

                entity.Property(e => e.Type).HasColumnType("int(11)");
            });

            modelBuilder.Entity<ReportOrderOther>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cost).HasColumnType("int(11)");

                entity.Property(e => e.Disc).HasColumnType("int(11)");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("Goods_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Profit).HasColumnType("int(11)");

                entity.Property(e => e.Qty).HasColumnType("int(11)");

                entity.Property(e => e.Sell).HasColumnType("int(11)");

                entity.Property(e => e.SpmId)
                    .HasColumnName("SPM_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SwoId)
                    .HasColumnName("SWO_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tax).HasColumnType("int(11)");

                entity.Property(e => e.Total).HasColumnType("int(11)");

                entity.Property(e => e.Type).HasColumnType("int(11)");
            });

            modelBuilder.Entity<ReportOrderProd>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cost).HasColumnType("int(11)");

                entity.Property(e => e.Disc).HasColumnType("int(11)");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("Goods_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Profit).HasColumnType("int(11)");

                entity.Property(e => e.Qty).HasColumnType("int(11)");

                entity.Property(e => e.Sell).HasColumnType("int(11)");

                entity.Property(e => e.SpmId)
                    .HasColumnName("SPM_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SwoId)
                    .HasColumnName("SWO_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tax).HasColumnType("int(11)");

                entity.Property(e => e.Total).HasColumnType("int(11)");

                entity.Property(e => e.Type).HasColumnType("int(11)");
            });

            modelBuilder.Entity<ReportOrderSale>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cost).HasColumnType("int(11)");

                entity.Property(e => e.Disc).HasColumnType("int(11)");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("Goods_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Profit).HasColumnType("int(11)");

                entity.Property(e => e.Qty).HasColumnType("int(11)");

                entity.Property(e => e.Sell).HasColumnType("int(11)");

                entity.Property(e => e.SpmId)
                    .HasColumnName("SPM_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SwoId)
                    .HasColumnName("SWO_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tax).HasColumnType("int(11)");

                entity.Property(e => e.Total).HasColumnType("int(11)");

                entity.Property(e => e.Type).HasColumnType("int(11)");
            });

            modelBuilder.Entity<ReportOrderStaff>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cost).HasColumnType("int(11)");

                entity.Property(e => e.Disc).HasColumnType("int(11)");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("Goods_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Profit).HasColumnType("int(11)");

                entity.Property(e => e.Qty).HasColumnType("int(11)");

                entity.Property(e => e.Sell).HasColumnType("int(11)");

                entity.Property(e => e.SpmId)
                    .HasColumnName("SPM_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SwoId)
                    .HasColumnName("SWO_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tax).HasColumnType("int(11)");

                entity.Property(e => e.Total).HasColumnType("int(11)");

                entity.Property(e => e.Type).HasColumnType("int(11)");
            });

            modelBuilder.Entity<ReportOverall>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PayAmount).HasColumnType("int(11)");

                entity.Property(e => e.ServiceCount).HasColumnType("int(11)");
            });

            modelBuilder.Entity<ReportPart>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cost).HasColumnType("int(11)");

                entity.Property(e => e.Disc).HasColumnType("int(11)");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("Goods_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PartName).HasMaxLength(50);

                entity.Property(e => e.PartTypeId).HasColumnType("int(11)");

                entity.Property(e => e.PartTypeName).HasMaxLength(50);

                entity.Property(e => e.Profit).HasColumnType("int(11)");

                entity.Property(e => e.Qty).HasColumnType("int(11)");

                entity.Property(e => e.Sell).HasColumnType("int(11)");

                entity.Property(e => e.SpmId)
                    .HasColumnName("SPM_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SwoId)
                    .HasColumnName("SWO_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tax).HasColumnType("int(11)");

                entity.Property(e => e.Total).HasColumnType("int(11)");

                entity.Property(e => e.Type).HasColumnType("int(11)");
            });

            modelBuilder.Entity<ReportSumary>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("int(11)");

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_Id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cellphone).HasMaxLength(50);

                entity.Property(e => e.Claim).HasColumnType("tinyint(1)");

                entity.Property(e => e.Courtesy).HasColumnType("tinyint(1)");

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.DelFlag).HasColumnType("int(11)");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(50);

                entity.Property(e => e.Insurance).HasColumnType("tinyint(1)");

                entity.Property(e => e.LicensePlateNumber).HasMaxLength(50);

                entity.Property(e => e.Maintenance).HasColumnType("tinyint(1)");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.Overhaul).HasColumnType("tinyint(1)");

                entity.Property(e => e.Pdi)
                    .HasColumnName("PDI")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.RepairShopInfoId)
                    .HasColumnName("RepairShopInfo_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReserDateTime)
                    .HasColumnName("Reser_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Towing).HasColumnType("tinyint(1)");

                entity.Property(e => e.UserInfoId)
                    .HasColumnName("UserInfo_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Vatnumber)
                    .HasColumnName("VATNumber")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RoleInfo>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DelFlag).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.RoleAuthorize).HasMaxLength(50);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SubTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShopAccountPayable>(entity =>
            {
                entity.HasIndex(e => e.RsaId)
                    .HasName("RSA_Id");

                entity.HasIndex(e => e.RssId)
                    .HasName("RSS_Id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Barcode).HasMaxLength(50);

                entity.Property(e => e.PoDate)
                    .HasColumnName("PO_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PoNo)
                    .HasColumnName("PO_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.RsaId)
                    .HasColumnName("RSA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RssId)
                    .HasColumnName("RSS_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Rsa)
                    .WithMany(p => p.ShopAccountPayable)
                    .HasForeignKey(d => d.RsaId)
                    .HasConstraintName("ShopAccountPayable_ibfk_1");

                entity.HasOne(d => d.Rss)
                    .WithMany(p => p.ShopAccountPayable)
                    .HasForeignKey(d => d.RssId)
                    .HasConstraintName("ShopAccountPayable_ibfk_2");
            });

            modelBuilder.Entity<ShopPackageDetail>(entity =>
            {
                entity.HasIndex(e => e.ShopPackageMainId)
                    .HasName("ShopPackageMain_Id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.GoodsId)
                    .HasColumnName("Goods_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GoodsType).HasColumnType("int(11)");

                entity.Property(e => e.ShopPackageMainId)
                    .HasColumnName("ShopPackageMain_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.ShopPackageMain)
                    .WithMany(p => p.ShopPackageDetail)
                    .HasForeignKey(d => d.ShopPackageMainId)
                    .HasConstraintName("ShopPackageDetail_ibfk_1");
            });

            modelBuilder.Entity<ShopPackageMain>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DelFlag).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.PackageName).HasMaxLength(50);

                entity.Property(e => e.RepairShopInfoId)
                    .HasColumnName("RepairShopInfo_Id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ShopPartsType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DelFlag).HasColumnType("int(11)");

                entity.Property(e => e.Expireterm).HasColumnType("int(11)");

                entity.Property(e => e.Mileage).HasColumnType("int(11)");

                entity.Property(e => e.PartsName).HasMaxLength(128);

                entity.Property(e => e.RepairShopInfoId)
                    .HasColumnName("RepairShopInfo_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShopPartsTypeCategoryId)
                    .HasColumnName("ShopPartsTypeCategory_Id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ShopPartsTypeCategory>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PartsType).HasMaxLength(50);
            });

            modelBuilder.Entity<ShopPartsTypeDefault>(entity =>
            {
                entity.HasIndex(e => e.ShopPartsTypeCategoryId)
                    .HasName("ShopPartsTypeCategory_Id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Expireterm).HasColumnType("int(11)");

                entity.Property(e => e.Mileage).HasColumnType("int(11)");

                entity.Property(e => e.PartsName).HasMaxLength(128);

                entity.Property(e => e.PartsNameEn).HasMaxLength(128);

                entity.Property(e => e.PartsNo).HasMaxLength(50);

                entity.Property(e => e.ShopPartsTypeCategoryId)
                    .HasColumnName("ShopPartsTypeCategory_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.ShopPartsTypeCategory)
                    .WithMany(p => p.ShopPartsTypeDefault)
                    .HasForeignKey(d => d.ShopPartsTypeCategoryId)
                    .HasConstraintName("ShopPartsTypeDefault_ibfk_1");
            });

            modelBuilder.Entity<ShopStaffProfile>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Cellphone).HasColumnType("char(20)");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.HourSalary).HasColumnType("int(11)");

                entity.Property(e => e.Job).HasMaxLength(50);

                entity.Property(e => e.RepairShopInfoId)
                    .HasColumnName("RepairShopInfo_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RestDays).HasMaxLength(50);

                entity.Property(e => e.Salary).HasMaxLength(50);

                entity.Property(e => e.StaffName).HasMaxLength(50);

                entity.Property(e => e.Telephone).HasColumnType("char(20)");

                entity.Property(e => e.UserInfoId)
                    .HasColumnName("UserInfo_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkHours).HasMaxLength(50);
            });

            modelBuilder.Entity<ShopWorkOrder>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Balance).HasMaxLength(50);

                entity.Property(e => e.CaId)
                    .HasColumnName("CA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Claim).HasColumnType("tinyint(1)");

                entity.Property(e => e.Courtesy).HasColumnType("tinyint(1)");

                entity.Property(e => e.CourtesyLicenseplateNumber).HasMaxLength(50);

                entity.Property(e => e.CvId)
                    .HasColumnName("CV_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateIn).HasColumnType("datetime");

                entity.Property(e => e.DateOut).HasColumnType("datetime");

                entity.Property(e => e.DelFlag).HasColumnType("int(11)");

                entity.Property(e => e.DiscountAgain)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Insurance).HasColumnType("tinyint(1)");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.Maintenance).HasColumnType("tinyint(1)");

                entity.Property(e => e.MaintenanceAdvice).HasMaxLength(50);

                entity.Property(e => e.MileageIn).HasMaxLength(50);

                entity.Property(e => e.MileageOut).HasMaxLength(50);

                entity.Property(e => e.NextMaintenanceDate).HasColumnType("datetime");

                entity.Property(e => e.Overhaul).HasColumnType("tinyint(1)");

                entity.Property(e => e.PaymentType).HasColumnType("int(11)");

                entity.Property(e => e.Pdi)
                    .HasColumnName("PDI")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.PlannedHours).HasMaxLength(50);

                entity.Property(e => e.RealHours).HasMaxLength(50);

                entity.Property(e => e.RsaId)
                    .HasColumnName("RSA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Towing).HasColumnType("tinyint(1)");

                entity.Property(e => e.TssaId)
                    .HasColumnName("TSSA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkOrderNumber).HasMaxLength(50);

                entity.Property(e => e.WorkPurpose).HasMaxLength(50);

                entity.Property(e => e.WorkStatus).HasColumnType("int(11)");

                entity.Property(e => e.Wpdescription)
                    .HasColumnName("WPDescription")
                    .HasMaxLength(50);

                entity.Property(e => e.WssaId)
                    .HasColumnName("WSSA_Id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ShopWorkOrderHistory>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarInformation).HasMaxLength(512);

                entity.Property(e => e.Cellphone).HasMaxLength(50);

                entity.Property(e => e.Claim).HasColumnType("tinyint(1)");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.ConsumerImgUrl).HasMaxLength(512);

                entity.Property(e => e.Courtesy).HasColumnType("tinyint(1)");

                entity.Property(e => e.CourtesyLicenseplateNumber).HasMaxLength(50);

                entity.Property(e => e.DateIn).HasColumnType("datetime");

                entity.Property(e => e.DateOut).HasColumnType("datetime");

                entity.Property(e => e.DiscountAgain).HasMaxLength(50);

                entity.Property(e => e.Driver).HasMaxLength(50);

                entity.Property(e => e.Insurance).HasColumnType("tinyint(1)");

                entity.Property(e => e.LicensePlateNumber).HasMaxLength(50);

                entity.Property(e => e.Maintenance).HasColumnType("tinyint(1)");

                entity.Property(e => e.MaintenanceAdvice).HasMaxLength(50);

                entity.Property(e => e.MileageIn).HasMaxLength(50);

                entity.Property(e => e.MileageOut).HasMaxLength(50);

                entity.Property(e => e.Month).HasColumnType("int(11)");

                entity.Property(e => e.NextMaintenanceDate).HasColumnType("datetime");

                entity.Property(e => e.Overhaul).HasColumnType("tinyint(1)");

                entity.Property(e => e.Pdi)
                    .HasColumnName("PDI")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.PlannedHours).HasMaxLength(50);

                entity.Property(e => e.RealHours).HasMaxLength(50);

                entity.Property(e => e.RepairShopInfoId)
                    .HasColumnName("RepairShopInfo_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Staff).HasMaxLength(50);

                entity.Property(e => e.Tax).HasMaxLength(50);

                entity.Property(e => e.Technician).HasMaxLength(50);

                entity.Property(e => e.Telphone).HasMaxLength(50);

                entity.Property(e => e.Total).HasMaxLength(50);

                entity.Property(e => e.TotalBeforeTax).HasMaxLength(50);

                entity.Property(e => e.Towing).HasColumnType("tinyint(1)");

                entity.Property(e => e.WorkOrderNumber).HasMaxLength(50);

                entity.Property(e => e.WorkPurpose).HasMaxLength(50);

                entity.Property(e => e.Wpddescription)
                    .HasColumnName("WPDDescription")
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnType("int(11)");
            });

            modelBuilder.Entity<ShopWorkOrderTemp>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Balance).HasMaxLength(50);

                entity.Property(e => e.CaId)
                    .HasColumnName("CA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Claim).HasColumnType("tinyint(1)");

                entity.Property(e => e.Courtesy).HasColumnType("tinyint(1)");

                entity.Property(e => e.CourtesyLicenseplateNumber).HasMaxLength(50);

                entity.Property(e => e.CvId)
                    .HasColumnName("CV_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateIn).HasColumnType("datetime");

                entity.Property(e => e.DateOut).HasColumnType("datetime");

                entity.Property(e => e.DelFlag).HasColumnType("int(11)");

                entity.Property(e => e.DiscountAgain)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Insurance).HasColumnType("tinyint(1)");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.Maintenance).HasColumnType("tinyint(1)");

                entity.Property(e => e.MaintenanceAdvice).HasMaxLength(50);

                entity.Property(e => e.MileageIn).HasMaxLength(50);

                entity.Property(e => e.MileageOut).HasMaxLength(50);

                entity.Property(e => e.NextMaintenanceDate).HasColumnType("datetime");

                entity.Property(e => e.Overhaul).HasColumnType("tinyint(1)");

                entity.Property(e => e.PaymentType).HasColumnType("int(11)");

                entity.Property(e => e.Pdi)
                    .HasColumnName("PDI")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.PlannedHours).HasMaxLength(50);

                entity.Property(e => e.RealHours).HasMaxLength(50);

                entity.Property(e => e.RsaId)
                    .HasColumnName("RSA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Towing).HasColumnType("tinyint(1)");

                entity.Property(e => e.TssaId)
                    .HasColumnName("TSSA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkOrderNumber).HasMaxLength(50);

                entity.Property(e => e.WorkPurpose).HasMaxLength(50);

                entity.Property(e => e.WorkStatus).HasColumnType("int(11)");

                entity.Property(e => e.Wpdescription)
                    .HasColumnName("WPDescription")
                    .HasMaxLength(50);

                entity.Property(e => e.WssaId)
                    .HasColumnName("WSSA_Id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TechAskCategory>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<TechAskQuestion>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Answer).HasColumnType("int(11)");

                entity.Property(e => e.AnswerCount).HasColumnType("int(11)");

                entity.Property(e => e.CalculateDate).HasColumnType("datetime");

                entity.Property(e => e.Content).HasMaxLength(500);

                entity.Property(e => e.RsaId)
                    .HasColumnName("RSA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SsaId)
                    .HasColumnName("SSA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TacId)
                    .HasColumnName("TAC_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.ViewCount).HasColumnType("int(11)");
            });

            modelBuilder.Entity<TechAskReply>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AsaId)
                    .HasColumnName("ASA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Content).HasMaxLength(500);

                entity.Property(e => e.RsaId)
                    .HasColumnName("RSA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SsaId)
                    .HasColumnName("SSA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status).HasColumnType("int(11)");

                entity.Property(e => e.TaqId)
                    .HasColumnName("TAQ_Id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UserGuide>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adddate).HasColumnType("datetime");

                entity.Property(e => e.ContentUrl).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DelFlag).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Pwd)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SubTime).HasColumnType("datetime");

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasColumnName("UName")
                    .HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("User_Id")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserInfoParent>(entity =>
            {
                entity.HasKey(e => new { e.UserInfoId, e.ParentId });

                entity.Property(e => e.UserInfoId).HasColumnType("int(11)");

                entity.Property(e => e.ParentId).HasColumnType("int(11)");

                entity.Property(e => e.DelFlag).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UserInfoRoleInfo>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DelFlag).HasColumnType("int(11)");

                entity.Property(e => e.RoleInfoId)
                    .HasColumnName("RoleInfo_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserInfoId)
                    .HasColumnName("UserInfo_Id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<VehicleCategory>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarLabel).HasMaxLength(200);
            });

            modelBuilder.Entity<VehicleModel>(entity =>
            {
                entity.HasIndex(e => e.VcId)
                    .HasName("VC_Id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarModel).HasMaxLength(200);

                entity.Property(e => e.VcId)
                    .HasColumnName("VC_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Vc)
                    .WithMany(p => p.VehicleModel)
                    .HasForeignKey(d => d.VcId)
                    .HasConstraintName("VehicleModel_ibfk_1");
            });

            modelBuilder.Entity<VehicleType>(entity =>
            {
                entity.HasIndex(e => e.VmId)
                    .HasName("VM_Id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarType).HasMaxLength(200);

                entity.Property(e => e.VmId)
                    .HasColumnName("VM_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Vm)
                    .WithMany(p => p.VehicleType)
                    .HasForeignKey(d => d.VmId)
                    .HasConstraintName("VehicleType_ibfk_1");
            });

            modelBuilder.Entity<WebDriverAccessLog>(entity =>
            {
                entity.ToTable("web_driver_access_log");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessFunctionUrl)
                    .IsRequired()
                    .HasColumnName("access_function_url")
                    .HasMaxLength(100);

                entity.Property(e => e.AccessTime)
                    .HasColumnName("access_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClientBrowser)
                    .HasColumnName("client_browser")
                    .HasMaxLength(200);

                entity.Property(e => e.ClientIp)
                    .IsRequired()
                    .HasColumnName("client_ip")
                    .HasMaxLength(15);

                entity.Property(e => e.ClientUser)
                    .IsRequired()
                    .HasColumnName("client_user")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("char(3)");

                entity.Property(e => e.TimeTaken)
                    .HasColumnName("time_taken")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WebTwshopAccessLog>(entity =>
            {
                entity.ToTable("web_twshop_access_log");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessFunctionUrl)
                    .IsRequired()
                    .HasColumnName("access_function_url")
                    .HasMaxLength(100);

                entity.Property(e => e.AccessTime)
                    .HasColumnName("access_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClientBrowser)
                    .HasColumnName("client_browser")
                    .HasMaxLength(200);

                entity.Property(e => e.ClientIp)
                    .IsRequired()
                    .HasColumnName("client_ip")
                    .HasMaxLength(15);

                entity.Property(e => e.ClientUser)
                    .IsRequired()
                    .HasColumnName("client_user")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("char(3)");

                entity.Property(e => e.TimeTaken)
                    .HasColumnName("time_taken")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WorkOrderAsk>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CaId)
                    .HasColumnName("CA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Content).HasMaxLength(256);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.ImgUrl).HasColumnType("char(50)");

                entity.Property(e => e.SsaId)
                    .HasColumnName("SSA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SwoId)
                    .HasColumnName("SWO_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SwotId)
                    .HasColumnName("SWOT_Id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WorkOrderDetail>(entity =>
            {
                entity.HasIndex(e => e.SwoId)
                    .HasName("SWO_Id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Disc).HasMaxLength(50);

                entity.Property(e => e.GoodsId)
                    .HasColumnName("Goods_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Qty).HasMaxLength(50);

                entity.Property(e => e.Sell).HasMaxLength(50);

                entity.Property(e => e.SpmId)
                    .HasColumnName("SPM_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SsaId)
                    .HasColumnName("SSA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SwoId)
                    .HasColumnName("SWO_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tax).HasMaxLength(50);

                entity.Property(e => e.Total).HasMaxLength(50);

                entity.Property(e => e.Type).HasColumnType("int(11)");

                entity.Property(e => e.WodId)
                    .HasColumnName("WOD_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Swo)
                    .WithMany(p => p.WorkOrderDetail)
                    .HasForeignKey(d => d.SwoId)
                    .HasConstraintName("WorkOrderDetail_ibfk_1");
            });

            modelBuilder.Entity<WorkOrderDetailHistory>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Disc).HasMaxLength(50);

                entity.Property(e => e.PackageName).HasMaxLength(50);

                entity.Property(e => e.Qty).HasMaxLength(50);

                entity.Property(e => e.Sell).HasMaxLength(50);

                entity.Property(e => e.ShopWorkOrderHistoryId)
                    .HasColumnName("ShopWorkOrderHistory_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tax).HasMaxLength(50);

                entity.Property(e => e.Technician).HasMaxLength(50);

                entity.Property(e => e.Total).HasMaxLength(50);

                entity.Property(e => e.Type).HasColumnType("int(11)");
            });

            modelBuilder.Entity<WorkOrderDetailTemp>(entity =>
            {
                entity.HasIndex(e => e.SwoId)
                    .HasName("SWO_Id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Disc).HasMaxLength(50);

                entity.Property(e => e.GoodsId)
                    .HasColumnName("Goods_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Qty).HasMaxLength(50);

                entity.Property(e => e.Sell).HasMaxLength(50);

                entity.Property(e => e.SpmId)
                    .HasColumnName("SPM_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SsaId)
                    .HasColumnName("SSA_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SwoId)
                    .HasColumnName("SWO_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tax).HasMaxLength(50);

                entity.Property(e => e.Total).HasMaxLength(50);

                entity.Property(e => e.Type).HasColumnType("int(11)");

                entity.Property(e => e.WodId)
                    .HasColumnName("WOD_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Swo)
                    .WithMany(p => p.WorkOrderDetailTemp)
                    .HasForeignKey(d => d.SwoId)
                    .HasConstraintName("WorkOrderDetailTemp_ibfk_1");
            });

            modelBuilder.Entity<WorkOrderPhoto>(entity =>
            {
                entity.HasIndex(e => e.SwoId)
                    .HasName("SWO_Id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ImgUrl).HasMaxLength(512);

                entity.Property(e => e.SwoId)
                    .HasColumnName("SWO_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Swo)
                    .WithMany(p => p.WorkOrderPhoto)
                    .HasForeignKey(d => d.SwoId)
                    .HasConstraintName("WorkOrderPhoto_ibfk_1");
            });

            modelBuilder.Entity<WorkOrderPhotoHistory>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ImgUrl).HasMaxLength(512);

                entity.Property(e => e.ShopWorkOrderHistoryId)
                    .HasColumnName("ShopWorkOrderHistory_Id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WorkOrderPhotoTemp>(entity =>
            {
                entity.HasIndex(e => e.SwoId)
                    .HasName("SWO_Id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ImgUrl).HasMaxLength(512);

                entity.Property(e => e.SwoId)
                    .HasColumnName("SWO_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Swo)
                    .WithMany(p => p.WorkOrderPhotoTemp)
                    .HasForeignKey(d => d.SwoId)
                    .HasConstraintName("WorkOrderPhotoTemp_ibfk_1");
            });

            modelBuilder.Entity<WorkOrderRating>(entity =>
            {
                entity.HasIndex(e => e.SwoId)
                    .HasName("SWO_Id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.SwoId)
                    .HasColumnName("SWO_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Swo)
                    .WithMany(p => p.WorkOrderRating)
                    .HasForeignKey(d => d.SwoId)
                    .HasConstraintName("WorkOrderRating_ibfk_1");
            });
        }
    }
}
