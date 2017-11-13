






using Autofac;
using Gomo.CC.EFDAL;
using Gomo.CC.IDAL;
using Gomo.CC.Model;
namespace Gomo.CC.DIModule
{

	public class DalModule : Autofac.Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<AccountPayDal>()
				.As<IAccountPayDal>().InstancePerLifetimeScope();

			builder.RegisterType<AccountReceivableDal>()
				.As<IAccountReceivableDal>().InstancePerLifetimeScope();

			builder.RegisterType<AdDetailDal>()
				.As<IAdDetailDal>().InstancePerLifetimeScope();

			builder.RegisterType<AdmanageDal>()
				.As<IAdmanageDal>().InstancePerLifetimeScope();

			builder.RegisterType<AdProfileDal>()
				.As<IAdProfileDal>().InstancePerLifetimeScope();

			builder.RegisterType<AuthorityPointDal>()
				.As<IAuthorityPointDal>().InstancePerLifetimeScope();

			builder.RegisterType<AuthorityPointLogDal>()
				.As<IAuthorityPointLogDal>().InstancePerLifetimeScope();

			builder.RegisterType<AutoMessageSetDal>()
				.As<IAutoMessageSetDal>().InstancePerLifetimeScope();

			builder.RegisterType<AutoMessageTypeDal>()
				.As<IAutoMessageTypeDal>().InstancePerLifetimeScope();

			builder.RegisterType<BestAnswerVoteDal>()
				.As<IBestAnswerVoteDal>().InstancePerLifetimeScope();

			builder.RegisterType<BillsPayableDal>()
				.As<IBillsPayableDal>().InstancePerLifetimeScope();

			builder.RegisterType<ConsumerAccountDal>()
				.As<IConsumerAccountDal>().InstancePerLifetimeScope();

			builder.RegisterType<ConsumerFaviorRepairShopDal>()
				.As<IConsumerFaviorRepairShopDal>().InstancePerLifetimeScope();

			builder.RegisterType<ConsumerProfileDal>()
				.As<IConsumerProfileDal>().InstancePerLifetimeScope();

			builder.RegisterType<ConsumerVehicleDal>()
				.As<IConsumerVehicleDal>().InstancePerLifetimeScope();

			builder.RegisterType<FaqcategoryDal>()
				.As<IFaqcategoryDal>().InstancePerLifetimeScope();

			builder.RegisterType<FaqlistDal>()
				.As<IFaqlistDal>().InstancePerLifetimeScope();

			builder.RegisterType<ForumCategoryDal>()
				.As<IForumCategoryDal>().InstancePerLifetimeScope();

			builder.RegisterType<ForumQuestionDal>()
				.As<IForumQuestionDal>().InstancePerLifetimeScope();

			builder.RegisterType<ForumReplyDal>()
				.As<IForumReplyDal>().InstancePerLifetimeScope();

			builder.RegisterType<GoodsAnswerDal>()
				.As<IGoodsAnswerDal>().InstancePerLifetimeScope();

			builder.RegisterType<GoodsListDal>()
				.As<IGoodsListDal>().InstancePerLifetimeScope();

			builder.RegisterType<GoodsOrderDal>()
				.As<IGoodsOrderDal>().InstancePerLifetimeScope();

			builder.RegisterType<GoodsOrderRatingDal>()
				.As<IGoodsOrderRatingDal>().InstancePerLifetimeScope();

			builder.RegisterType<GoodsPhotoDal>()
				.As<IGoodsPhotoDal>().InstancePerLifetimeScope();

			builder.RegisterType<GoodsQuestionDal>()
				.As<IGoodsQuestionDal>().InstancePerLifetimeScope();

			builder.RegisterType<ImgFileDal>()
				.As<IImgFileDal>().InstancePerLifetimeScope();

			builder.RegisterType<ImgServerDal>()
				.As<IImgServerDal>().InstancePerLifetimeScope();

			builder.RegisterType<MessageNotifyDal>()
				.As<IMessageNotifyDal>().InstancePerLifetimeScope();

			builder.RegisterType<MessageRecordDal>()
				.As<IMessageRecordDal>().InstancePerLifetimeScope();

			builder.RegisterType<MessageTypeDal>()
				.As<IMessageTypeDal>().InstancePerLifetimeScope();

			builder.RegisterType<OrderInfoDal>()
				.As<IOrderInfoDal>().InstancePerLifetimeScope();

			builder.RegisterType<QuestionListDal>()
				.As<IQuestionListDal>().InstancePerLifetimeScope();

			builder.RegisterType<RepairConsumerProfileDal>()
				.As<IRepairConsumerProfileDal>().InstancePerLifetimeScope();

			builder.RegisterType<RepairConsumerVehicleDal>()
				.As<IRepairConsumerVehicleDal>().InstancePerLifetimeScope();

			builder.RegisterType<RepairShopAccountDal>()
				.As<IRepairShopAccountDal>().InstancePerLifetimeScope();

			builder.RegisterType<RepairShopInfoDal>()
				.As<IRepairShopInfoDal>().InstancePerLifetimeScope();

			builder.RegisterType<RepairShopInventoryDal>()
				.As<IRepairShopInventoryDal>().InstancePerLifetimeScope();

			builder.RegisterType<RepairShopInventoryTransactionDal>()
				.As<IRepairShopInventoryTransactionDal>().InstancePerLifetimeScope();

			builder.RegisterType<RepairShopLaborDal>()
				.As<IRepairShopLaborDal>().InstancePerLifetimeScope();

			builder.RegisterType<RepairShopLaborCategoryDal>()
				.As<IRepairShopLaborCategoryDal>().InstancePerLifetimeScope();

			builder.RegisterType<RepairShopLaborDefaultDal>()
				.As<IRepairShopLaborDefaultDal>().InstancePerLifetimeScope();

			builder.RegisterType<RepairShopLaborTypeDal>()
				.As<IRepairShopLaborTypeDal>().InstancePerLifetimeScope();

			builder.RegisterType<RepairShopPhotoDal>()
				.As<IRepairShopPhotoDal>().InstancePerLifetimeScope();

			builder.RegisterType<RepairShopRatingDal>()
				.As<IRepairShopRatingDal>().InstancePerLifetimeScope();

			builder.RegisterType<RepairShopSupplierDal>()
				.As<IRepairShopSupplierDal>().InstancePerLifetimeScope();

			builder.RegisterType<RepairShopUserInfoDal>()
				.As<IRepairShopUserInfoDal>().InstancePerLifetimeScope();

			builder.RegisterType<ReplyListDal>()
				.As<IReplyListDal>().InstancePerLifetimeScope();

			builder.RegisterType<ReportCustCarDal>()
				.As<IReportCustCarDal>().InstancePerLifetimeScope();

			builder.RegisterType<ReportCustomerDal>()
				.As<IReportCustomerDal>().InstancePerLifetimeScope();

			builder.RegisterType<ReportCustOtherDal>()
				.As<IReportCustOtherDal>().InstancePerLifetimeScope();

			builder.RegisterType<ReportCustProdDal>()
				.As<IReportCustProdDal>().InstancePerLifetimeScope();

			builder.RegisterType<ReportCustSaleDal>()
				.As<IReportCustSaleDal>().InstancePerLifetimeScope();

			builder.RegisterType<ReportCustStaffDal>()
				.As<IReportCustStaffDal>().InstancePerLifetimeScope();

			builder.RegisterType<ReportInvRecvDal>()
				.As<IReportInvRecvDal>().InstancePerLifetimeScope();

			builder.RegisterType<ReportOrderCarDal>()
				.As<IReportOrderCarDal>().InstancePerLifetimeScope();

			builder.RegisterType<ReportOrderDetailDal>()
				.As<IReportOrderDetailDal>().InstancePerLifetimeScope();

			builder.RegisterType<ReportOrderOtherDal>()
				.As<IReportOrderOtherDal>().InstancePerLifetimeScope();

			builder.RegisterType<ReportOrderProdDal>()
				.As<IReportOrderProdDal>().InstancePerLifetimeScope();

			builder.RegisterType<ReportOrderSaleDal>()
				.As<IReportOrderSaleDal>().InstancePerLifetimeScope();

			builder.RegisterType<ReportOrderStaffDal>()
				.As<IReportOrderStaffDal>().InstancePerLifetimeScope();

			builder.RegisterType<ReportOverallDal>()
				.As<IReportOverallDal>().InstancePerLifetimeScope();

			builder.RegisterType<ReportPartDal>()
				.As<IReportPartDal>().InstancePerLifetimeScope();

			builder.RegisterType<ReportSumaryDal>()
				.As<IReportSumaryDal>().InstancePerLifetimeScope();

			builder.RegisterType<ReservationDal>()
				.As<IReservationDal>().InstancePerLifetimeScope();

			builder.RegisterType<RoleInfoDal>()
				.As<IRoleInfoDal>().InstancePerLifetimeScope();

			builder.RegisterType<ShopAccountPayableDal>()
				.As<IShopAccountPayableDal>().InstancePerLifetimeScope();

			builder.RegisterType<ShopPackageDetailDal>()
				.As<IShopPackageDetailDal>().InstancePerLifetimeScope();

			builder.RegisterType<ShopPackageMainDal>()
				.As<IShopPackageMainDal>().InstancePerLifetimeScope();

			builder.RegisterType<ShopPartsTypeDal>()
				.As<IShopPartsTypeDal>().InstancePerLifetimeScope();

			builder.RegisterType<ShopPartsTypeCategoryDal>()
				.As<IShopPartsTypeCategoryDal>().InstancePerLifetimeScope();

			builder.RegisterType<ShopPartsTypeDefaultDal>()
				.As<IShopPartsTypeDefaultDal>().InstancePerLifetimeScope();

			builder.RegisterType<ShopStaffProfileDal>()
				.As<IShopStaffProfileDal>().InstancePerLifetimeScope();

			builder.RegisterType<ShopWorkOrderDal>()
				.As<IShopWorkOrderDal>().InstancePerLifetimeScope();

			builder.RegisterType<ShopWorkOrderHistoryDal>()
				.As<IShopWorkOrderHistoryDal>().InstancePerLifetimeScope();

			builder.RegisterType<ShopWorkOrderTempDal>()
				.As<IShopWorkOrderTempDal>().InstancePerLifetimeScope();

			builder.RegisterType<TechAskCategoryDal>()
				.As<ITechAskCategoryDal>().InstancePerLifetimeScope();

			builder.RegisterType<TechAskQuestionDal>()
				.As<ITechAskQuestionDal>().InstancePerLifetimeScope();

			builder.RegisterType<TechAskReplyDal>()
				.As<ITechAskReplyDal>().InstancePerLifetimeScope();

			builder.RegisterType<UserGuideDal>()
				.As<IUserGuideDal>().InstancePerLifetimeScope();

			builder.RegisterType<UserInfoDal>()
				.As<IUserInfoDal>().InstancePerLifetimeScope();

			builder.RegisterType<UserInfoParentDal>()
				.As<IUserInfoParentDal>().InstancePerLifetimeScope();

			builder.RegisterType<UserInfoRoleInfoDal>()
				.As<IUserInfoRoleInfoDal>().InstancePerLifetimeScope();

			builder.RegisterType<VehicleCategoryDal>()
				.As<IVehicleCategoryDal>().InstancePerLifetimeScope();

			builder.RegisterType<VehicleModelDal>()
				.As<IVehicleModelDal>().InstancePerLifetimeScope();

			builder.RegisterType<VehicleTypeDal>()
				.As<IVehicleTypeDal>().InstancePerLifetimeScope();

			builder.RegisterType<WebDriverAccessLogDal>()
				.As<IWebDriverAccessLogDal>().InstancePerLifetimeScope();

			builder.RegisterType<WebTwshopAccessLogDal>()
				.As<IWebTwshopAccessLogDal>().InstancePerLifetimeScope();

			builder.RegisterType<WorkOrderAskDal>()
				.As<IWorkOrderAskDal>().InstancePerLifetimeScope();

			builder.RegisterType<WorkOrderDetailDal>()
				.As<IWorkOrderDetailDal>().InstancePerLifetimeScope();

			builder.RegisterType<WorkOrderDetailHistoryDal>()
				.As<IWorkOrderDetailHistoryDal>().InstancePerLifetimeScope();

			builder.RegisterType<WorkOrderDetailTempDal>()
				.As<IWorkOrderDetailTempDal>().InstancePerLifetimeScope();

			builder.RegisterType<WorkOrderPhotoDal>()
				.As<IWorkOrderPhotoDal>().InstancePerLifetimeScope();

			builder.RegisterType<WorkOrderPhotoHistoryDal>()
				.As<IWorkOrderPhotoHistoryDal>().InstancePerLifetimeScope();

			builder.RegisterType<WorkOrderPhotoTempDal>()
				.As<IWorkOrderPhotoTempDal>().InstancePerLifetimeScope();

			builder.RegisterType<WorkOrderRatingDal>()
				.As<IWorkOrderRatingDal>().InstancePerLifetimeScope();

		}
	}
}


