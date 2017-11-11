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
                entity.Property(e => e.Bank).HasMaxLength(50);

                entity.Property(e => e.BankAccount).HasMaxLength(50);

                entity.Property(e => e.CheckNumber).HasMaxLength(50);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(50);

                entity.Property(e => e.RepairShopInfoId).HasColumnName("RepairShopInfo_Id");

                entity.Property(e => e.SuppilerName).HasMaxLength(50);

                entity.Property(e => e.Total).HasColumnType("nchar(10)");
            });

            modelBuilder.Entity<AccountReceivable>(entity =>
            {
                entity.Property(e => e.Balance).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Note).HasMaxLength(100);

                entity.Property(e => e.Paid).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Payer).HasMaxLength(50);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.ReceivableDate).HasColumnType("datetime");

                entity.Property(e => e.ShopWorkOrderHistoryId).HasColumnName("ShopWorkOrderHistory_Id");

                entity.Property(e => e.SubTotabl).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Tax).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<AdDetail>(entity =>
            {
                entity.Property(e => e.AdProfileId).HasColumnName("AdProfile_Id");

                entity.Property(e => e.PlayEndDate).HasColumnType("datetime");

                entity.Property(e => e.PlayStartDate).HasColumnType("datetime");

                entity.Property(e => e.Url).HasMaxLength(128);
            });

            modelBuilder.Entity<Admanage>(entity =>
            {
                entity.ToTable("ADManage");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adname)
                    .IsRequired()
                    .HasColumnName("ADName")
                    .HasMaxLength(50);

                entity.Property(e => e.Adstatus)
                    .HasColumnName("ADStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Adtype)
                    .HasColumnName("ADType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Adurl)
                    .IsRequired()
                    .HasColumnName("ADUrl")
                    .HasMaxLength(50);

                entity.Property(e => e.AiId)
                    .HasColumnName("AI_Id")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AdProfile>(entity =>
            {
                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UserInfoId).HasColumnName("UserInfo_Id");
            });

            modelBuilder.Entity<AuthorityPoint>(entity =>
            {
                entity.Property(e => e.AuthorityPoint1).HasColumnName("Authority_Point");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AuthorityPointLog>(entity =>
            {
                entity.Property(e => e.AuthorityPoint).HasColumnName("Authority_Point");

                entity.Property(e => e.Description).HasMaxLength(128);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AutoMessageSet>(entity =>
            {
                entity.Property(e => e.MediaTypeLine)
                    .HasColumnName("MediaType_Line")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MediaTypeMessenger)
                    .HasColumnName("MediaType_Messenger")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MediaTypeSms)
                    .HasColumnName("MediaType_SMS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MediaTypeWechat)
                    .HasColumnName("MediaType_Wechat")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MessageContent).IsRequired();

                entity.Property(e => e.RsaId).HasColumnName("RSA_Id");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.MessageTypeNavigation)
                    .WithMany(p => p.AutoMessageSet)
                    .HasForeignKey(d => d.MessageType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AutoMessageSet_AutoMessageType");
            });

            modelBuilder.Entity<AutoMessageType>(entity =>
            {
                entity.Property(e => e.MessageType).HasMaxLength(50);
            });

            modelBuilder.Entity<BestAnswerVote>(entity =>
            {
                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.RsaId).HasColumnName("RSA_Id");

                entity.Property(e => e.SsaId).HasColumnName("SSA_Id");

                entity.Property(e => e.TaqId).HasColumnName("TAQ_Id");

                entity.Property(e => e.TarId).HasColumnName("TAR_Id");
            });

            modelBuilder.Entity<BillsPayable>(entity =>
            {
                entity.Property(e => e.AccountId)
                    .HasColumnName("Account_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountName)
                    .HasColumnName("Account_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.BillsAmount).HasColumnName("Bills_Amount");

                entity.Property(e => e.BillsId)
                    .HasColumnName("Bills_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.ExchangeDate)
                    .HasColumnName("Exchange_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ConsumerAccount>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ConsumerId)
                    .HasColumnName("ConsumerID")
                    .HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.RsaId).HasColumnName("RSA_Id");

                entity.HasOne(d => d.Rsa)
                    .WithMany(p => p.ConsumerAccount)
                    .HasForeignKey(d => d.RsaId)
                    .HasConstraintName("FK_ConsumerAccount_RepairShopAccount");
            });

            modelBuilder.Entity<ConsumerFaviorRepairShop>(entity =>
            {
                entity.Property(e => e.RepairShopInfoId).HasColumnName("RepairShopInfo_Id");

                entity.Property(e => e.UserInfoId).HasColumnName("UserInfo_Id");
            });

            modelBuilder.Entity<ConsumerProfile>(entity =>
            {
                entity.Property(e => e.Address1).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.Address3).HasMaxLength(50);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.CaId).HasColumnName("CA_Id");

                entity.Property(e => e.Cellphone).HasMaxLength(50);

                entity.Property(e => e.ConsumerName).HasMaxLength(50);

                entity.Property(e => e.Discount).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fburl)
                    .HasColumnName("FBUrl")
                    .HasMaxLength(50);

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .HasMaxLength(50);

                entity.Property(e => e.PayTypeAccount).HasColumnName("PayType_Account");

                entity.Property(e => e.PayTypeCash).HasColumnName("PayType_Cash");

                entity.Property(e => e.PayTypeCheck).HasColumnName("PayType_Check");

                entity.Property(e => e.PayTypeCredit).HasColumnName("PayType_Credit");

                entity.Property(e => e.PayTypeDebit).HasColumnName("PayType_Debit");

                entity.Property(e => e.PayTypeMasterCard).HasColumnName("PayType_MasterCard");

                entity.Property(e => e.Referralentry).HasMaxLength(50);

                entity.Property(e => e.Sms)
                    .HasColumnName("SMS")
                    .HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.Property(e => e.UserInfoId).HasColumnName("UserInfo_Id");

                entity.Property(e => e.WechatId)
                    .HasColumnName("WechatID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ConsumerVehicle>(entity =>
            {
                entity.Property(e => e.CaId).HasColumnName("CA_Id");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.CurrentLicenseDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfManufcture).HasColumnType("datetime");

                entity.Property(e => e.ImgUrl).HasMaxLength(512);

                entity.Property(e => e.InsuranceExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.LicensePlateNumber).HasMaxLength(50);

                entity.Property(e => e.Milage).HasMaxLength(50);

                entity.Property(e => e.NextMaintainMileage).HasMaxLength(50);

                entity.Property(e => e.UserInfoId).HasColumnName("UserInfo_Id");

                entity.Property(e => e.VcId).HasColumnName("VC_Id");

                entity.Property(e => e.VmId).HasColumnName("VM_Id");

                entity.Property(e => e.VtId).HasColumnName("VT_Id");

                entity.Property(e => e.Year).HasMaxLength(50);
            });

            modelBuilder.Entity<Faqcategory>(entity =>
            {
                entity.ToTable("FAQCategory");

                entity.Property(e => e.CategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<Faqlist>(entity =>
            {
                entity.ToTable("FAQList");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Content).HasMaxLength(500);

                entity.Property(e => e.FaqcId).HasColumnName("FAQC_Id");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.Faqc)
                    .WithMany(p => p.Faqlist)
                    .HasForeignKey(d => d.FaqcId)
                    .HasConstraintName("FK_FAQList_FAQCategory");
            });

            modelBuilder.Entity<ForumCategory>(entity =>
            {
                entity.Property(e => e.CategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<ForumQuestion>(entity =>
            {
                entity.Property(e => e.AccountId).HasColumnName("Account_Id");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Content).HasMaxLength(50);

                entity.Property(e => e.FcId).HasColumnName("FC_Id");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.Fc)
                    .WithMany(p => p.ForumQuestion)
                    .HasForeignKey(d => d.FcId)
                    .HasConstraintName("FK_ForumQuestion_ForumCategory");
            });

            modelBuilder.Entity<ForumReply>(entity =>
            {
                entity.Property(e => e.AccountId).HasColumnName("Account_Id");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Content).HasMaxLength(100);

                entity.Property(e => e.FqId).HasColumnName("FQ_Id");

                entity.HasOne(d => d.Fq)
                    .WithMany(p => p.ForumReply)
                    .HasForeignKey(d => d.FqId)
                    .HasConstraintName("FK_ForumReply_ForumQuestion");
            });

            modelBuilder.Entity<GoodsAnswer>(entity =>
            {
                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Content).HasMaxLength(50);

                entity.Property(e => e.GqId).HasColumnName("GQ_Id");

                entity.HasOne(d => d.Gq)
                    .WithMany(p => p.GoodsAnswer)
                    .HasForeignKey(d => d.GqId)
                    .HasConstraintName("FK_GoodsAnswer_GoodsQuestion");
            });

            modelBuilder.Entity<GoodsList>(entity =>
            {
                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.DealInformation).HasMaxLength(50);

                entity.Property(e => e.GoodsDescription).HasMaxLength(50);

                entity.Property(e => e.GoodsName).HasColumnType("nchar(20)");

                entity.Property(e => e.GoolsName).HasColumnType("datetime");

                entity.Property(e => e.RsaId).HasColumnName("RSA_Id");

                entity.Property(e => e.RsiId).HasColumnName("RSI_Id");
            });

            modelBuilder.Entity<GoodsOrder>(entity =>
            {
                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.RsaId).HasColumnName("RSA_Id");

                entity.Property(e => e.Rules).HasMaxLength(50);

                entity.Property(e => e.ShipDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<GoodsOrderRating>(entity =>
            {
                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.GlId).HasColumnName("GL_Id");

                entity.Property(e => e.GoId).HasColumnName("GO_Id");

                entity.Property(e => e.Rating).HasColumnType("nchar(10)");

                entity.HasOne(d => d.Gl)
                    .WithMany(p => p.GoodsOrderRating)
                    .HasForeignKey(d => d.GlId)
                    .HasConstraintName("FK_GoodsOrderRating_GoodsList");
            });

            modelBuilder.Entity<GoodsPhoto>(entity =>
            {
                entity.Property(e => e.GlId).HasColumnName("GL_Id");

                entity.Property(e => e.ImgUrl).HasMaxLength(512);

                entity.HasOne(d => d.Gl)
                    .WithMany(p => p.GoodsPhoto)
                    .HasForeignKey(d => d.GlId)
                    .HasConstraintName("FK_GoodsPhoto_GoodsList");
            });

            modelBuilder.Entity<GoodsQuestion>(entity =>
            {
                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Content).HasMaxLength(50);

                entity.Property(e => e.GlId).HasColumnName("GL_Id");

                entity.Property(e => e.RsaId).HasColumnName("RSA_Id");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.Gl)
                    .WithMany(p => p.GoodsQuestion)
                    .HasForeignKey(d => d.GlId)
                    .HasConstraintName("FK_GoodsQuestion_GoodsList");
            });

            modelBuilder.Entity<ImgFile>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.PathFileName).HasMaxLength(128);

                entity.Property(e => e.ServerId).HasColumnName("Server_Id");
            });

            modelBuilder.Entity<ImgServer>(entity =>
            {
                entity.Property(e => e.Account).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Path).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasColumnName("ServerIP")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MessageNotify>(entity =>
            {
                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.DestId).HasColumnName("Dest_Id");

                entity.Property(e => e.ExpTime).HasColumnType("date");

                entity.Property(e => e.MesTypeId).HasColumnName("MesType_Id");

                entity.Property(e => e.ReservationId).HasColumnName("Reservation_Id");

                entity.Property(e => e.SendId).HasColumnName("Send_Id");

                entity.Property(e => e.SubTime).HasColumnType("date");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<MessageRecord>(entity =>
            {
                entity.Property(e => e.CaId).HasColumnName("CA_Id");

                entity.Property(e => e.MessageContent).HasMaxLength(50);

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.RsaId).HasColumnName("RSA_Id");
            });

            modelBuilder.Entity<MessageType>(entity =>
            {
                entity.Property(e => e.MessageEnum).HasMaxLength(32);

                entity.Property(e => e.MessageName).HasMaxLength(50);
            });

            modelBuilder.Entity<OrderInfo>(entity =>
            {
                entity.Property(e => e.Content).HasMaxLength(64);
            });

            modelBuilder.Entity<QuestionList>(entity =>
            {
                entity.Property(e => e.AccountId).HasColumnName("Account_Id");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Content).HasMaxLength(50);

                entity.Property(e => e.FaqcId).HasColumnName("FAQC_Id");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.Faqc)
                    .WithMany(p => p.QuestionList)
                    .HasForeignKey(d => d.FaqcId)
                    .HasConstraintName("FK_QuestionList_FAQCategory");
            });

            modelBuilder.Entity<RepairConsumerProfile>(entity =>
            {
                entity.Property(e => e.Address1).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.Address3).HasMaxLength(50);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.CaId).HasColumnName("CA_Id");

                entity.Property(e => e.Cellphone).HasMaxLength(50);

                entity.Property(e => e.ConsumerId)
                    .HasColumnName("ConsumerID")
                    .HasMaxLength(50);

                entity.Property(e => e.ConsumerName).HasMaxLength(50);

                entity.Property(e => e.ConsumerProfileId).HasColumnName("ConsumerProfile_Id");

                entity.Property(e => e.Discount).HasMaxLength(50);

                entity.Property(e => e.Driver).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fburl)
                    .HasColumnName("FBUrl")
                    .HasMaxLength(50);

                entity.Property(e => e.LineId)
                    .HasColumnName("LineID")
                    .HasMaxLength(50);

                entity.Property(e => e.PayTypeAccount).HasColumnName("PayType_Account");

                entity.Property(e => e.PayTypeCash).HasColumnName("PayType_Cash");

                entity.Property(e => e.PayTypeCheck).HasColumnName("PayType_Check");

                entity.Property(e => e.PayTypeCredit).HasColumnName("PayType_Credit");

                entity.Property(e => e.PayTypeDebit).HasColumnName("PayType_Debit");

                entity.Property(e => e.PayTypeMasterCard).HasColumnName("PayType_MasterCard");

                entity.Property(e => e.Quota).HasMaxLength(50);

                entity.Property(e => e.Referralentry).HasMaxLength(50);

                entity.Property(e => e.RepairShopInfoId).HasColumnName("RepairShopInfo_Id");

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
                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.DateOfManufcture).HasColumnType("datetime");

                entity.Property(e => e.ImgUrl).HasMaxLength(512);

                entity.Property(e => e.InspectionDate).HasColumnType("datetime");

                entity.Property(e => e.InsuranceExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.LicensePlateNumber).HasMaxLength(50);

                entity.Property(e => e.Milage).HasMaxLength(50);

                entity.Property(e => e.NextMaintainMileage).HasMaxLength(50);

                entity.Property(e => e.RcpId).HasColumnName("RCP_Id");

                entity.Property(e => e.VcId).HasColumnName("VC_Id");

                entity.Property(e => e.VmId).HasColumnName("VM_Id");

                entity.Property(e => e.VtId).HasColumnName("VT_Id");

                entity.Property(e => e.Year).HasMaxLength(50);

                entity.HasOne(d => d.Rcp)
                    .WithMany(p => p.RepairConsumerVehicle)
                    .HasForeignKey(d => d.RcpId)
                    .HasConstraintName("FK_RepairConsumerVehicle_RepairConsumerProfile");
            });

            modelBuilder.Entity<RepairShopAccount>(entity =>
            {
                entity.Property(e => e.AaiId).HasColumnName("AAI_Id");

                entity.Property(e => e.AccountNo).HasMaxLength(50);

                entity.Property(e => e.EndDate)
                    .HasColumnName("End_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.StartDate)
                    .HasColumnName("Start_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<RepairShopInfo>(entity =>
            {
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
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("Expire_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PartName).HasMaxLength(50);

                entity.Property(e => e.PartNo)
                    .HasColumnName("PartNO")
                    .HasMaxLength(50);

                entity.Property(e => e.PoDate)
                    .HasColumnName("PO_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PoNo).HasColumnName("PO_NO");

                entity.Property(e => e.PoQty).HasColumnName("PO_Qty");

                entity.Property(e => e.RepairShopInfoId).HasColumnName("RepairShopInfo_Id");

                entity.Property(e => e.SafeQty).HasColumnName("Safe_Qty");

                entity.Property(e => e.ShopPartsTypeId).HasColumnName("ShopPartsType_Id");

                entity.Property(e => e.StockQty).HasColumnName("Stock_Qty");

                entity.HasOne(d => d.PoNoNavigation)
                    .WithMany(p => p.RepairShopInventory)
                    .HasForeignKey(d => d.PoNo)
                    .HasConstraintName("FK_RepairShopInventory_ShopAccountPayable2");
            });

            modelBuilder.Entity<RepairShopInventoryTransaction>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Method)
                    .IsRequired()
                    .HasColumnName("method")
                    .HasColumnType("char(1)");

                entity.Property(e => e.OpPrice)
                    .HasColumnName("op_price")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OpQty).HasColumnName("op_qty");

                entity.Property(e => e.OpTime).HasColumnName("op_time");

                entity.Property(e => e.RefFormId).HasColumnName("ref_form_id");

                entity.Property(e => e.RefFormNote)
                    .HasColumnName("ref_form_note")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RefFormType)
                    .HasColumnName("ref_form_type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RepairShopInfoId).HasColumnName("RepairShopInfo_Id");

                entity.Property(e => e.RepairShopInventoryId).HasColumnName("RepairShopInventory_id");
            });

            modelBuilder.Entity<RepairShopLabor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Qty).HasDefaultValueSql("((0))");

                entity.Property(e => e.RepairShopInfoId).HasColumnName("RepairShopInfo_Id");

                entity.Property(e => e.ServiceItems).HasMaxLength(128);
            });

            modelBuilder.Entity<RepairShopLaborCategory>(entity =>
            {
                entity.Property(e => e.LaborType).HasMaxLength(50);
            });

            modelBuilder.Entity<RepairShopLaborDefault>(entity =>
            {
                entity.Property(e => e.LaborTypeNo)
                    .HasColumnName("LaborTypeNO")
                    .HasMaxLength(50);

                entity.Property(e => e.Qty).HasDefaultValueSql("((0))");

                entity.Property(e => e.RepairShopLaborCategoryId).HasColumnName("RepairShopLaborCategory_Id");

                entity.Property(e => e.ServiceItems).HasMaxLength(128);

                entity.Property(e => e.ServiceItemsEn).HasMaxLength(128);

                entity.HasOne(d => d.RepairShopLaborCategory)
                    .WithMany(p => p.RepairShopLaborDefault)
                    .HasForeignKey(d => d.RepairShopLaborCategoryId)
                    .HasConstraintName("FK_RepairShopLaborDefault_RepairShopLaborCategory");
            });

            modelBuilder.Entity<RepairShopLaborType>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.RepairShopInfoId).HasColumnName("RepairShopInfo_Id");

                entity.Property(e => e.RepairShopLaborCategoryId).HasColumnName("RepairShopLaborCategory_Id");

                entity.Property(e => e.ServiceItems).HasMaxLength(50);
            });

            modelBuilder.Entity<RepairShopPhoto>(entity =>
            {
                entity.Property(e => e.RepairShopInfoId).HasColumnName("RepairShopInfo_Id");

                entity.Property(e => e.ServiceImgUrl).HasMaxLength(512);
            });

            modelBuilder.Entity<RepairShopRating>(entity =>
            {
                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.RepairShopInfoId).HasColumnName("RepairShopInfo_Id");
            });

            modelBuilder.Entity<RepairShopSupplier>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address1).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.Address3).HasMaxLength(50);

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Paymentterm).HasColumnName("paymentterm");

                entity.Property(e => e.RepairShopInfoId).HasColumnName("RepairShopInfo_Id");

                entity.Property(e => e.ShopPartsTypeId).HasColumnName("ShopPartsType_Id");

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
                entity.Property(e => e.RepairShopInfoId).HasColumnName("RepairShopInfo_Id");

                entity.Property(e => e.UserInfoId).HasColumnName("UserInfo_Id");
            });

            modelBuilder.Entity<ReplyList>(entity =>
            {
                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Content).HasMaxLength(50);

                entity.Property(e => e.QlId).HasColumnName("QL_Id");

                entity.Property(e => e.SmaId).HasColumnName("SMA_Id");

                entity.HasOne(d => d.Ql)
                    .WithMany(p => p.ReplyList)
                    .HasForeignKey(d => d.QlId)
                    .HasConstraintName("FK_ReplyList_QuestionList");
            });

            modelBuilder.Entity<ReportCustCar>(entity =>
            {
                entity.Property(e => e.CarName).HasMaxLength(50);

                entity.Property(e => e.ConsumerName).HasMaxLength(50);

                entity.Property(e => e.DateOut).HasColumnType("datetime");

                entity.Property(e => e.LaborAmt).HasColumnName("Labor_Amt");

                entity.Property(e => e.LicensePlateNumber).HasMaxLength(50);

                entity.Property(e => e.PartAmt).HasColumnName("Part_Amt");

                entity.Property(e => e.RswoId).HasColumnName("RSWO_Id");

                entity.Property(e => e.StaffName).HasMaxLength(50);

                entity.Property(e => e.WorkOrderNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportCustomer>(entity =>
            {
                entity.Property(e => e.CarName).HasMaxLength(50);

                entity.Property(e => e.ConsumerName).HasMaxLength(50);

                entity.Property(e => e.DateOut).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.LaborAmt).HasColumnName("Labor_Amt");

                entity.Property(e => e.LicensePlateNumber).HasMaxLength(50);

                entity.Property(e => e.PartAmt).HasColumnName("Part_Amt");

                entity.Property(e => e.RswoId).HasColumnName("RSWO_Id");

                entity.Property(e => e.StaffName).HasMaxLength(50);

                entity.Property(e => e.WorkOrderNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportCustOther>(entity =>
            {
                entity.Property(e => e.CarName).HasMaxLength(50);

                entity.Property(e => e.ConsumerName).HasMaxLength(50);

                entity.Property(e => e.DateOut).HasColumnType("datetime");

                entity.Property(e => e.LaborAmt).HasColumnName("Labor_Amt");

                entity.Property(e => e.LicensePlateNumber).HasMaxLength(50);

                entity.Property(e => e.PartAmt).HasColumnName("Part_Amt");

                entity.Property(e => e.RswoId).HasColumnName("RSWO_Id");

                entity.Property(e => e.StaffName).HasMaxLength(50);

                entity.Property(e => e.WorkOrderNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportCustProd>(entity =>
            {
                entity.Property(e => e.CarName).HasMaxLength(50);

                entity.Property(e => e.ConsumerName).HasMaxLength(50);

                entity.Property(e => e.DateOut).HasColumnType("datetime");

                entity.Property(e => e.LaborAmt).HasColumnName("Labor_Amt");

                entity.Property(e => e.LicensePlateNumber).HasMaxLength(50);

                entity.Property(e => e.PartAmt).HasColumnName("Part_Amt");

                entity.Property(e => e.RswoId).HasColumnName("RSWO_Id");

                entity.Property(e => e.StaffName).HasMaxLength(50);

                entity.Property(e => e.WorkOrderNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportCustSale>(entity =>
            {
                entity.Property(e => e.CarName).HasMaxLength(50);

                entity.Property(e => e.ConsumerName).HasMaxLength(50);

                entity.Property(e => e.DateOut).HasColumnType("datetime");

                entity.Property(e => e.LaborAmt).HasColumnName("Labor_Amt");

                entity.Property(e => e.LicensePlateNumber).HasMaxLength(50);

                entity.Property(e => e.PartAmt).HasColumnName("Part_Amt");

                entity.Property(e => e.RswoId).HasColumnName("RSWO_Id");

                entity.Property(e => e.StaffName).HasMaxLength(50);

                entity.Property(e => e.WorkOrderNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportCustStaff>(entity =>
            {
                entity.Property(e => e.CarName).HasMaxLength(50);

                entity.Property(e => e.ConsumerName).HasMaxLength(50);

                entity.Property(e => e.DateOut).HasColumnType("datetime");

                entity.Property(e => e.LaborAmt).HasColumnName("Labor_Amt");

                entity.Property(e => e.LicensePlateNumber).HasMaxLength(50);

                entity.Property(e => e.PartAmt).HasColumnName("Part_Amt");

                entity.Property(e => e.RswoId).HasColumnName("RSWO_Id");

                entity.Property(e => e.StaffName).HasMaxLength(50);

                entity.Property(e => e.WorkOrderNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportInvRecv>(entity =>
            {
                entity.Property(e => e.CaId).HasColumnName("CA_Id");

                entity.Property(e => e.ConsumerName).HasMaxLength(50);

                entity.Property(e => e.DateOut).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.RswoId).HasColumnName("RSWO_Id");

                entity.Property(e => e.WorkOrderNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportOrderCar>(entity =>
            {
                entity.Property(e => e.GoodsId).HasColumnName("Goods_Id");

                entity.Property(e => e.SpmId).HasColumnName("SPM_Id");

                entity.Property(e => e.SwoId).HasColumnName("SWO_Id");
            });

            modelBuilder.Entity<ReportOrderDetail>(entity =>
            {
                entity.Property(e => e.GoodsId).HasColumnName("Goods_Id");

                entity.Property(e => e.SpmId).HasColumnName("SPM_Id");

                entity.Property(e => e.SwoId).HasColumnName("SWO_Id");
            });

            modelBuilder.Entity<ReportOrderOther>(entity =>
            {
                entity.Property(e => e.GoodsId).HasColumnName("Goods_Id");

                entity.Property(e => e.SpmId).HasColumnName("SPM_Id");

                entity.Property(e => e.SwoId).HasColumnName("SWO_Id");
            });

            modelBuilder.Entity<ReportOrderProd>(entity =>
            {
                entity.Property(e => e.GoodsId).HasColumnName("Goods_Id");

                entity.Property(e => e.SpmId).HasColumnName("SPM_Id");

                entity.Property(e => e.SwoId).HasColumnName("SWO_Id");
            });

            modelBuilder.Entity<ReportOrderSale>(entity =>
            {
                entity.Property(e => e.GoodsId).HasColumnName("Goods_Id");

                entity.Property(e => e.SpmId).HasColumnName("SPM_Id");

                entity.Property(e => e.SwoId).HasColumnName("SWO_Id");
            });

            modelBuilder.Entity<ReportOrderStaff>(entity =>
            {
                entity.Property(e => e.GoodsId).HasColumnName("Goods_Id");

                entity.Property(e => e.SpmId).HasColumnName("SPM_Id");

                entity.Property(e => e.SwoId).HasColumnName("SWO_Id");
            });

            modelBuilder.Entity<ReportPart>(entity =>
            {
                entity.Property(e => e.GoodsId).HasColumnName("Goods_Id");

                entity.Property(e => e.PartName).HasMaxLength(50);

                entity.Property(e => e.PartTypeName).HasMaxLength(50);

                entity.Property(e => e.SpmId).HasColumnName("SPM_Id");

                entity.Property(e => e.SwoId).HasColumnName("SWO_Id");
            });

            modelBuilder.Entity<ReportSumary>(entity =>
            {
                entity.Property(e => e.ReportId).HasColumnName("Report_Id");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.Property(e => e.Cellphone).HasMaxLength(50);

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(50);

                entity.Property(e => e.LicensePlateNumber).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.Pdi).HasColumnName("PDI");

                entity.Property(e => e.RepairShopInfoId).HasColumnName("RepairShopInfo_Id");

                entity.Property(e => e.ReserDateTime)
                    .HasColumnName("Reser_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserInfoId).HasColumnName("UserInfo_Id");

                entity.Property(e => e.Vatnumber)
                    .HasColumnName("VATNumber")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RoleInfo>(entity =>
            {
                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.RoleAuthorize).HasMaxLength(50);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SubTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShopAccountPayable>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Barcode).HasMaxLength(50);

                entity.Property(e => e.PoDate)
                    .HasColumnName("PO_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PoNo)
                    .HasColumnName("PO_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.RsaId).HasColumnName("RSA_Id");

                entity.Property(e => e.RssId).HasColumnName("RSS_Id");

                entity.HasOne(d => d.Rsa)
                    .WithMany(p => p.ShopAccountPayable)
                    .HasForeignKey(d => d.RsaId)
                    .HasConstraintName("FK_ShopAccountPayable_RepairShopAccount");

                entity.HasOne(d => d.Rss)
                    .WithMany(p => p.ShopAccountPayable)
                    .HasForeignKey(d => d.RssId)
                    .HasConstraintName("FK_ShopAccountPayable_RepairShopSupplier");
            });

            modelBuilder.Entity<ShopPackageDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GoodsId).HasColumnName("Goods_Id");

                entity.Property(e => e.ShopPackageMainId).HasColumnName("ShopPackageMain_Id");

                entity.HasOne(d => d.ShopPackageMain)
                    .WithMany(p => p.ShopPackageDetail)
                    .HasForeignKey(d => d.ShopPackageMainId)
                    .HasConstraintName("FK_ShopPackageDetail_ShopPackageMain");
            });

            modelBuilder.Entity<ShopPackageMain>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.PackageName).HasMaxLength(50);

                entity.Property(e => e.RepairShopInfoId).HasColumnName("RepairShopInfo_Id");
            });

            modelBuilder.Entity<ShopPartsType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.PartsName).HasMaxLength(128);

                entity.Property(e => e.RepairShopInfoId).HasColumnName("RepairShopInfo_Id");

                entity.Property(e => e.ShopPartsTypeCategoryId).HasColumnName("ShopPartsTypeCategory_Id");
            });

            modelBuilder.Entity<ShopPartsTypeCategory>(entity =>
            {
                entity.Property(e => e.PartsType).HasMaxLength(50);
            });

            modelBuilder.Entity<ShopPartsTypeDefault>(entity =>
            {
                entity.Property(e => e.PartsName).HasMaxLength(128);

                entity.Property(e => e.PartsNameEn).HasMaxLength(128);

                entity.Property(e => e.PartsNo).HasMaxLength(50);

                entity.Property(e => e.ShopPartsTypeCategoryId).HasColumnName("ShopPartsTypeCategory_Id");

                entity.HasOne(d => d.ShopPartsTypeCategory)
                    .WithMany(p => p.ShopPartsTypeDefault)
                    .HasForeignKey(d => d.ShopPartsTypeCategoryId)
                    .HasConstraintName("FK_ShopPartsTypeDefault_ShopPartsTypeCategory");
            });

            modelBuilder.Entity<ShopStaffProfile>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Cellphone).HasColumnType("nchar(20)");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Job).HasMaxLength(50);

                entity.Property(e => e.RepairShopInfoId).HasColumnName("RepairShopInfo_Id");

                entity.Property(e => e.RestDays).HasMaxLength(50);

                entity.Property(e => e.Salary).HasMaxLength(50);

                entity.Property(e => e.StaffName).HasMaxLength(50);

                entity.Property(e => e.Telephone).HasColumnType("nchar(20)");

                entity.Property(e => e.UserInfoId).HasColumnName("UserInfo_Id");

                entity.Property(e => e.WorkHours).HasMaxLength(50);
            });

            modelBuilder.Entity<ShopWorkOrder>(entity =>
            {
                entity.Property(e => e.Balance).HasMaxLength(50);

                entity.Property(e => e.CaId).HasColumnName("CA_Id");

                entity.Property(e => e.CourtesyLicenseplateNumber).HasMaxLength(50);

                entity.Property(e => e.CvId).HasColumnName("CV_Id");

                entity.Property(e => e.DateIn).HasColumnType("datetime");

                entity.Property(e => e.DateOut).HasColumnType("datetime");

                entity.Property(e => e.DiscountAgain)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.MaintenanceAdvice).HasMaxLength(50);

                entity.Property(e => e.MileageIn).HasMaxLength(50);

                entity.Property(e => e.MileageOut).HasMaxLength(50);

                entity.Property(e => e.NextMaintenanceDate).HasColumnType("datetime");

                entity.Property(e => e.Pdi).HasColumnName("PDI");

                entity.Property(e => e.PlannedHours).HasMaxLength(50);

                entity.Property(e => e.RealHours).HasMaxLength(50);

                entity.Property(e => e.RsaId).HasColumnName("RSA_Id");

                entity.Property(e => e.TssaId).HasColumnName("TSSA_Id");

                entity.Property(e => e.WorkOrderNumber).HasMaxLength(50);

                entity.Property(e => e.WorkPurpose).HasMaxLength(50);

                entity.Property(e => e.Wpdescription)
                    .HasColumnName("WPDescription")
                    .HasMaxLength(50);

                entity.Property(e => e.WssaId).HasColumnName("WSSA_Id");
            });

            modelBuilder.Entity<ShopWorkOrderHistory>(entity =>
            {
                entity.Property(e => e.CarInformation).HasMaxLength(512);

                entity.Property(e => e.Cellphone).HasMaxLength(50);

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.ConsumerImgUrl).HasMaxLength(512);

                entity.Property(e => e.CourtesyLicenseplateNumber).HasMaxLength(50);

                entity.Property(e => e.DateIn).HasColumnType("datetime");

                entity.Property(e => e.DateOut).HasColumnType("datetime");

                entity.Property(e => e.DiscountAgain).HasMaxLength(50);

                entity.Property(e => e.Driver).HasMaxLength(50);

                entity.Property(e => e.LicensePlateNumber).HasMaxLength(50);

                entity.Property(e => e.MaintenanceAdvice).HasMaxLength(50);

                entity.Property(e => e.MileageIn).HasMaxLength(50);

                entity.Property(e => e.MileageOut).HasMaxLength(50);

                entity.Property(e => e.NextMaintenanceDate).HasColumnType("datetime");

                entity.Property(e => e.Pdi).HasColumnName("PDI");

                entity.Property(e => e.PlannedHours).HasMaxLength(50);

                entity.Property(e => e.RealHours).HasMaxLength(50);

                entity.Property(e => e.RepairShopInfoId).HasColumnName("RepairShopInfo_Id");

                entity.Property(e => e.Staff).HasMaxLength(50);

                entity.Property(e => e.Tax).HasMaxLength(50);

                entity.Property(e => e.Technician).HasMaxLength(50);

                entity.Property(e => e.Telphone).HasMaxLength(50);

                entity.Property(e => e.Total).HasMaxLength(50);

                entity.Property(e => e.TotalBeforeTax).HasMaxLength(50);

                entity.Property(e => e.WorkOrderNumber).HasMaxLength(50);

                entity.Property(e => e.WorkPurpose).HasMaxLength(50);

                entity.Property(e => e.Wpddescription)
                    .HasColumnName("WPDDescription")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ShopWorkOrderTemp>(entity =>
            {
                entity.Property(e => e.Balance).HasMaxLength(50);

                entity.Property(e => e.CaId).HasColumnName("CA_Id");

                entity.Property(e => e.CourtesyLicenseplateNumber).HasMaxLength(50);

                entity.Property(e => e.CvId).HasColumnName("CV_Id");

                entity.Property(e => e.DateIn).HasColumnType("datetime");

                entity.Property(e => e.DateOut).HasColumnType("datetime");

                entity.Property(e => e.DiscountAgain)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.MaintenanceAdvice).HasMaxLength(50);

                entity.Property(e => e.MileageIn).HasMaxLength(50);

                entity.Property(e => e.MileageOut).HasMaxLength(50);

                entity.Property(e => e.NextMaintenanceDate).HasColumnType("datetime");

                entity.Property(e => e.Pdi).HasColumnName("PDI");

                entity.Property(e => e.PlannedHours).HasMaxLength(50);

                entity.Property(e => e.RealHours).HasMaxLength(50);

                entity.Property(e => e.RsaId).HasColumnName("RSA_Id");

                entity.Property(e => e.TssaId).HasColumnName("TSSA_Id");

                entity.Property(e => e.WorkOrderNumber).HasMaxLength(50);

                entity.Property(e => e.WorkPurpose).HasMaxLength(50);

                entity.Property(e => e.Wpdescription)
                    .HasColumnName("WPDescription")
                    .HasMaxLength(50);

                entity.Property(e => e.WssaId).HasColumnName("WSSA_Id");
            });

            modelBuilder.Entity<TechAskCategory>(entity =>
            {
                entity.Property(e => e.CategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<TechAskQuestion>(entity =>
            {
                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.CalculateDate).HasColumnType("datetime");

                entity.Property(e => e.Content).HasMaxLength(500);

                entity.Property(e => e.RsaId).HasColumnName("RSA_Id");

                entity.Property(e => e.SsaId).HasColumnName("SSA_Id");

                entity.Property(e => e.TacId).HasColumnName("TAC_Id");

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<TechAskReply>(entity =>
            {
                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AsaId).HasColumnName("ASA_Id");

                entity.Property(e => e.Content).HasMaxLength(500);

                entity.Property(e => e.RsaId).HasColumnName("RSA_Id");

                entity.Property(e => e.SsaId).HasColumnName("SSA_Id");

                entity.Property(e => e.TaqId).HasColumnName("TAQ_Id");
            });

            modelBuilder.Entity<UserGuide>(entity =>
            {
                entity.Property(e => e.Adddate).HasColumnType("datetime");

                entity.Property(e => e.ContentUrl).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
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
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserInfoParent>(entity =>
            {
                entity.HasKey(e => new { e.UserInfoId, e.ParentId });
            });

            modelBuilder.Entity<UserInfoRoleInfo>(entity =>
            {
                entity.Property(e => e.RoleInfoId).HasColumnName("RoleInfo_Id");

                entity.Property(e => e.UserInfoId).HasColumnName("UserInfo_Id");
            });

            modelBuilder.Entity<VehicleCategory>(entity =>
            {
                entity.Property(e => e.CarLabel).HasMaxLength(200);
            });

            modelBuilder.Entity<VehicleModel>(entity =>
            {
                entity.Property(e => e.CarModel).HasMaxLength(200);

                entity.Property(e => e.VcId).HasColumnName("VC_Id");

                entity.HasOne(d => d.Vc)
                    .WithMany(p => p.VehicleModel)
                    .HasForeignKey(d => d.VcId)
                    .HasConstraintName("FK_VehicleModel_VehicleCategory");
            });

            modelBuilder.Entity<VehicleType>(entity =>
            {
                entity.Property(e => e.CarType).HasMaxLength(200);

                entity.Property(e => e.VmId).HasColumnName("VM_Id");

                entity.HasOne(d => d.Vm)
                    .WithMany(p => p.VehicleType)
                    .HasForeignKey(d => d.VmId)
                    .HasConstraintName("FK_VehicleType_VehicleModel");
            });

            modelBuilder.Entity<WebDriverAccessLog>(entity =>
            {
                entity.ToTable("web_driver_access_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessFunctionUrl)
                    .IsRequired()
                    .HasColumnName("access_function_url")
                    .HasMaxLength(100);

                entity.Property(e => e.AccessTime).HasColumnName("access_time");

                entity.Property(e => e.ClientBrowser)
                    .HasColumnName("client_browser")
                    .HasMaxLength(200);

                entity.Property(e => e.ClientIp)
                    .IsRequired()
                    .HasColumnName("client_ip")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ClientUser)
                    .IsRequired()
                    .HasColumnName("client_user")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("char(3)");

                entity.Property(e => e.TimeTaken).HasColumnName("time_taken");
            });

            modelBuilder.Entity<WebTwshopAccessLog>(entity =>
            {
                entity.ToTable("web_twshop_access_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessFunctionUrl)
                    .IsRequired()
                    .HasColumnName("access_function_url")
                    .HasMaxLength(100);

                entity.Property(e => e.AccessTime).HasColumnName("access_time");

                entity.Property(e => e.ClientBrowser)
                    .HasColumnName("client_browser")
                    .HasMaxLength(200);

                entity.Property(e => e.ClientIp)
                    .IsRequired()
                    .HasColumnName("client_ip")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ClientUser)
                    .IsRequired()
                    .HasColumnName("client_user")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("char(3)");

                entity.Property(e => e.TimeTaken).HasColumnName("time_taken");
            });

            modelBuilder.Entity<WorkOrderAsk>(entity =>
            {
                entity.Property(e => e.CaId).HasColumnName("CA_Id");

                entity.Property(e => e.Content).HasMaxLength(256);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.ImgUrl).HasColumnType("nchar(50)");

                entity.Property(e => e.SsaId).HasColumnName("SSA_Id");

                entity.Property(e => e.SwoId).HasColumnName("SWO_Id");

                entity.Property(e => e.SwotId).HasColumnName("SWOT_Id");
            });

            modelBuilder.Entity<WorkOrderDetail>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Disc).HasMaxLength(50);

                entity.Property(e => e.GoodsId).HasColumnName("Goods_Id");

                entity.Property(e => e.Qty).HasMaxLength(50);

                entity.Property(e => e.Sell).HasMaxLength(50);

                entity.Property(e => e.SpmId).HasColumnName("SPM_Id");

                entity.Property(e => e.SsaId).HasColumnName("SSA_Id");

                entity.Property(e => e.SwoId).HasColumnName("SWO_Id");

                entity.Property(e => e.Tax).HasMaxLength(50);

                entity.Property(e => e.Total).HasMaxLength(50);

                entity.Property(e => e.WodId).HasColumnName("WOD_Id");

                entity.HasOne(d => d.Swo)
                    .WithMany(p => p.WorkOrderDetail)
                    .HasForeignKey(d => d.SwoId)
                    .HasConstraintName("FK_WorkOrderDetail_ShopWorkOrder2");
            });

            modelBuilder.Entity<WorkOrderDetailHistory>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Disc).HasMaxLength(50);

                entity.Property(e => e.PackageName).HasMaxLength(50);

                entity.Property(e => e.Qty).HasMaxLength(50);

                entity.Property(e => e.Sell).HasMaxLength(50);

                entity.Property(e => e.ShopWorkOrderHistoryId).HasColumnName("ShopWorkOrderHistory_Id");

                entity.Property(e => e.Tax).HasMaxLength(50);

                entity.Property(e => e.Technician).HasMaxLength(50);

                entity.Property(e => e.Total).HasMaxLength(50);
            });

            modelBuilder.Entity<WorkOrderDetailTemp>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Disc).HasMaxLength(50);

                entity.Property(e => e.GoodsId).HasColumnName("Goods_Id");

                entity.Property(e => e.Qty).HasMaxLength(50);

                entity.Property(e => e.Sell).HasMaxLength(50);

                entity.Property(e => e.SpmId).HasColumnName("SPM_Id");

                entity.Property(e => e.SsaId).HasColumnName("SSA_Id");

                entity.Property(e => e.SwoId).HasColumnName("SWO_Id");

                entity.Property(e => e.Tax).HasMaxLength(50);

                entity.Property(e => e.Total).HasMaxLength(50);

                entity.Property(e => e.WodId).HasColumnName("WOD_Id");

                entity.HasOne(d => d.Swo)
                    .WithMany(p => p.WorkOrderDetailTemp)
                    .HasForeignKey(d => d.SwoId)
                    .HasConstraintName("FK_WorkOrderDetailTemp_ShopWorkOrderTemp");
            });

            modelBuilder.Entity<WorkOrderPhoto>(entity =>
            {
                entity.Property(e => e.ImgUrl).HasMaxLength(512);

                entity.Property(e => e.SwoId).HasColumnName("SWO_Id");

                entity.HasOne(d => d.Swo)
                    .WithMany(p => p.WorkOrderPhoto)
                    .HasForeignKey(d => d.SwoId)
                    .HasConstraintName("FK_WorkOrderPhoto_ShopWorkOrder");
            });

            modelBuilder.Entity<WorkOrderPhotoHistory>(entity =>
            {
                entity.Property(e => e.ImgUrl).HasMaxLength(512);

                entity.Property(e => e.ShopWorkOrderHistoryId).HasColumnName("ShopWorkOrderHistory_Id");
            });

            modelBuilder.Entity<WorkOrderPhotoTemp>(entity =>
            {
                entity.Property(e => e.ImgUrl).HasMaxLength(512);

                entity.Property(e => e.SwoId).HasColumnName("SWO_Id");

                entity.HasOne(d => d.Swo)
                    .WithMany(p => p.WorkOrderPhotoTemp)
                    .HasForeignKey(d => d.SwoId)
                    .HasConstraintName("FK_WorkOrderPhotoTemp_ShopWorkOrderTemp");
            });

            modelBuilder.Entity<WorkOrderRating>(entity =>
            {
                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.SwoId).HasColumnName("SWO_Id");

                entity.HasOne(d => d.Swo)
                    .WithMany(p => p.WorkOrderRating)
                    .HasForeignKey(d => d.SwoId)
                    .HasConstraintName("FK_WorkOrderRating_ShopWorkOrder");
            });
        }
    }
}
