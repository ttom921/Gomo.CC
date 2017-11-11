






using Autofac;
using Gomo.CC.BLL;
using Gomo.CC.IBLL;
namespace Gomo.CC.DIModule
{

	public class ServiceModule : Autofac.Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<AccountPayService>()
				.As<IAccountPayService>().InstancePerLifetimeScope();

			builder.RegisterType<AccountReceivableService>()
				.As<IAccountReceivableService>().InstancePerLifetimeScope();

			builder.RegisterType<AdDetailService>()
				.As<IAdDetailService>().InstancePerLifetimeScope();

			builder.RegisterType<AdmanageService>()
				.As<IAdmanageService>().InstancePerLifetimeScope();

			builder.RegisterType<AdProfileService>()
				.As<IAdProfileService>().InstancePerLifetimeScope();

			builder.RegisterType<AuthorityPointService>()
				.As<IAuthorityPointService>().InstancePerLifetimeScope();

			builder.RegisterType<AuthorityPointLogService>()
				.As<IAuthorityPointLogService>().InstancePerLifetimeScope();

			builder.RegisterType<AutoMessageSetService>()
				.As<IAutoMessageSetService>().InstancePerLifetimeScope();

			builder.RegisterType<AutoMessageTypeService>()
				.As<IAutoMessageTypeService>().InstancePerLifetimeScope();

			builder.RegisterType<BestAnswerVoteService>()
				.As<IBestAnswerVoteService>().InstancePerLifetimeScope();

			builder.RegisterType<BillsPayableService>()
				.As<IBillsPayableService>().InstancePerLifetimeScope();

			builder.RegisterType<ConsumerAccountService>()
				.As<IConsumerAccountService>().InstancePerLifetimeScope();

			builder.RegisterType<ConsumerFaviorRepairShopService>()
				.As<IConsumerFaviorRepairShopService>().InstancePerLifetimeScope();

			builder.RegisterType<ConsumerProfileService>()
				.As<IConsumerProfileService>().InstancePerLifetimeScope();

			builder.RegisterType<ConsumerVehicleService>()
				.As<IConsumerVehicleService>().InstancePerLifetimeScope();

			builder.RegisterType<FaqcategoryService>()
				.As<IFaqcategoryService>().InstancePerLifetimeScope();

			builder.RegisterType<FaqlistService>()
				.As<IFaqlistService>().InstancePerLifetimeScope();

			builder.RegisterType<ForumCategoryService>()
				.As<IForumCategoryService>().InstancePerLifetimeScope();

			builder.RegisterType<ForumQuestionService>()
				.As<IForumQuestionService>().InstancePerLifetimeScope();

			builder.RegisterType<ForumReplyService>()
				.As<IForumReplyService>().InstancePerLifetimeScope();

			builder.RegisterType<GoodsAnswerService>()
				.As<IGoodsAnswerService>().InstancePerLifetimeScope();

			builder.RegisterType<GoodsListService>()
				.As<IGoodsListService>().InstancePerLifetimeScope();

			builder.RegisterType<GoodsOrderService>()
				.As<IGoodsOrderService>().InstancePerLifetimeScope();

			builder.RegisterType<GoodsOrderRatingService>()
				.As<IGoodsOrderRatingService>().InstancePerLifetimeScope();

			builder.RegisterType<GoodsPhotoService>()
				.As<IGoodsPhotoService>().InstancePerLifetimeScope();

			builder.RegisterType<GoodsQuestionService>()
				.As<IGoodsQuestionService>().InstancePerLifetimeScope();

			builder.RegisterType<ImgFileService>()
				.As<IImgFileService>().InstancePerLifetimeScope();

			builder.RegisterType<ImgServerService>()
				.As<IImgServerService>().InstancePerLifetimeScope();

			builder.RegisterType<MessageNotifyService>()
				.As<IMessageNotifyService>().InstancePerLifetimeScope();

			builder.RegisterType<MessageRecordService>()
				.As<IMessageRecordService>().InstancePerLifetimeScope();

			builder.RegisterType<MessageTypeService>()
				.As<IMessageTypeService>().InstancePerLifetimeScope();

			builder.RegisterType<OrderInfoService>()
				.As<IOrderInfoService>().InstancePerLifetimeScope();

			builder.RegisterType<QuestionListService>()
				.As<IQuestionListService>().InstancePerLifetimeScope();

			builder.RegisterType<RepairConsumerProfileService>()
				.As<IRepairConsumerProfileService>().InstancePerLifetimeScope();

			builder.RegisterType<RepairConsumerVehicleService>()
				.As<IRepairConsumerVehicleService>().InstancePerLifetimeScope();

			builder.RegisterType<RepairShopAccountService>()
				.As<IRepairShopAccountService>().InstancePerLifetimeScope();

			builder.RegisterType<RepairShopInfoService>()
				.As<IRepairShopInfoService>().InstancePerLifetimeScope();

			builder.RegisterType<RepairShopInventoryService>()
				.As<IRepairShopInventoryService>().InstancePerLifetimeScope();

			builder.RegisterType<RepairShopInventoryTransactionService>()
				.As<IRepairShopInventoryTransactionService>().InstancePerLifetimeScope();

			builder.RegisterType<RepairShopLaborService>()
				.As<IRepairShopLaborService>().InstancePerLifetimeScope();

			builder.RegisterType<RepairShopLaborCategoryService>()
				.As<IRepairShopLaborCategoryService>().InstancePerLifetimeScope();

			builder.RegisterType<RepairShopLaborDefaultService>()
				.As<IRepairShopLaborDefaultService>().InstancePerLifetimeScope();

			builder.RegisterType<RepairShopLaborTypeService>()
				.As<IRepairShopLaborTypeService>().InstancePerLifetimeScope();

			builder.RegisterType<RepairShopPhotoService>()
				.As<IRepairShopPhotoService>().InstancePerLifetimeScope();

			builder.RegisterType<RepairShopRatingService>()
				.As<IRepairShopRatingService>().InstancePerLifetimeScope();

			builder.RegisterType<RepairShopSupplierService>()
				.As<IRepairShopSupplierService>().InstancePerLifetimeScope();

			builder.RegisterType<RepairShopUserInfoService>()
				.As<IRepairShopUserInfoService>().InstancePerLifetimeScope();

			builder.RegisterType<ReplyListService>()
				.As<IReplyListService>().InstancePerLifetimeScope();

			builder.RegisterType<ReportCustCarService>()
				.As<IReportCustCarService>().InstancePerLifetimeScope();

			builder.RegisterType<ReportCustomerService>()
				.As<IReportCustomerService>().InstancePerLifetimeScope();

			builder.RegisterType<ReportCustOtherService>()
				.As<IReportCustOtherService>().InstancePerLifetimeScope();

			builder.RegisterType<ReportCustProdService>()
				.As<IReportCustProdService>().InstancePerLifetimeScope();

			builder.RegisterType<ReportCustSaleService>()
				.As<IReportCustSaleService>().InstancePerLifetimeScope();

			builder.RegisterType<ReportCustStaffService>()
				.As<IReportCustStaffService>().InstancePerLifetimeScope();

			builder.RegisterType<ReportInvRecvService>()
				.As<IReportInvRecvService>().InstancePerLifetimeScope();

			builder.RegisterType<ReportOrderCarService>()
				.As<IReportOrderCarService>().InstancePerLifetimeScope();

			builder.RegisterType<ReportOrderDetailService>()
				.As<IReportOrderDetailService>().InstancePerLifetimeScope();

			builder.RegisterType<ReportOrderOtherService>()
				.As<IReportOrderOtherService>().InstancePerLifetimeScope();

			builder.RegisterType<ReportOrderProdService>()
				.As<IReportOrderProdService>().InstancePerLifetimeScope();

			builder.RegisterType<ReportOrderSaleService>()
				.As<IReportOrderSaleService>().InstancePerLifetimeScope();

			builder.RegisterType<ReportOrderStaffService>()
				.As<IReportOrderStaffService>().InstancePerLifetimeScope();

			builder.RegisterType<ReportOverallService>()
				.As<IReportOverallService>().InstancePerLifetimeScope();

			builder.RegisterType<ReportPartService>()
				.As<IReportPartService>().InstancePerLifetimeScope();

			builder.RegisterType<ReportSumaryService>()
				.As<IReportSumaryService>().InstancePerLifetimeScope();

			builder.RegisterType<ReservationService>()
				.As<IReservationService>().InstancePerLifetimeScope();

			builder.RegisterType<RoleInfoService>()
				.As<IRoleInfoService>().InstancePerLifetimeScope();

			builder.RegisterType<ShopAccountPayableService>()
				.As<IShopAccountPayableService>().InstancePerLifetimeScope();

			builder.RegisterType<ShopPackageDetailService>()
				.As<IShopPackageDetailService>().InstancePerLifetimeScope();

			builder.RegisterType<ShopPackageMainService>()
				.As<IShopPackageMainService>().InstancePerLifetimeScope();

			builder.RegisterType<ShopPartsTypeService>()
				.As<IShopPartsTypeService>().InstancePerLifetimeScope();

			builder.RegisterType<ShopPartsTypeCategoryService>()
				.As<IShopPartsTypeCategoryService>().InstancePerLifetimeScope();

			builder.RegisterType<ShopPartsTypeDefaultService>()
				.As<IShopPartsTypeDefaultService>().InstancePerLifetimeScope();

			builder.RegisterType<ShopStaffProfileService>()
				.As<IShopStaffProfileService>().InstancePerLifetimeScope();

			builder.RegisterType<ShopWorkOrderService>()
				.As<IShopWorkOrderService>().InstancePerLifetimeScope();

			builder.RegisterType<ShopWorkOrderHistoryService>()
				.As<IShopWorkOrderHistoryService>().InstancePerLifetimeScope();

			builder.RegisterType<ShopWorkOrderTempService>()
				.As<IShopWorkOrderTempService>().InstancePerLifetimeScope();

			builder.RegisterType<TechAskCategoryService>()
				.As<ITechAskCategoryService>().InstancePerLifetimeScope();

			builder.RegisterType<TechAskQuestionService>()
				.As<ITechAskQuestionService>().InstancePerLifetimeScope();

			builder.RegisterType<TechAskReplyService>()
				.As<ITechAskReplyService>().InstancePerLifetimeScope();

			builder.RegisterType<UserGuideService>()
				.As<IUserGuideService>().InstancePerLifetimeScope();

			builder.RegisterType<UserInfoService>()
				.As<IUserInfoService>().InstancePerLifetimeScope();

			builder.RegisterType<UserInfoParentService>()
				.As<IUserInfoParentService>().InstancePerLifetimeScope();

			builder.RegisterType<UserInfoRoleInfoService>()
				.As<IUserInfoRoleInfoService>().InstancePerLifetimeScope();

			builder.RegisterType<VehicleCategoryService>()
				.As<IVehicleCategoryService>().InstancePerLifetimeScope();

			builder.RegisterType<VehicleModelService>()
				.As<IVehicleModelService>().InstancePerLifetimeScope();

			builder.RegisterType<VehicleTypeService>()
				.As<IVehicleTypeService>().InstancePerLifetimeScope();

			builder.RegisterType<WebDriverAccessLogService>()
				.As<IWebDriverAccessLogService>().InstancePerLifetimeScope();

			builder.RegisterType<WebTwshopAccessLogService>()
				.As<IWebTwshopAccessLogService>().InstancePerLifetimeScope();

			builder.RegisterType<WorkOrderAskService>()
				.As<IWorkOrderAskService>().InstancePerLifetimeScope();

			builder.RegisterType<WorkOrderDetailService>()
				.As<IWorkOrderDetailService>().InstancePerLifetimeScope();

			builder.RegisterType<WorkOrderDetailHistoryService>()
				.As<IWorkOrderDetailHistoryService>().InstancePerLifetimeScope();

			builder.RegisterType<WorkOrderDetailTempService>()
				.As<IWorkOrderDetailTempService>().InstancePerLifetimeScope();

			builder.RegisterType<WorkOrderPhotoService>()
				.As<IWorkOrderPhotoService>().InstancePerLifetimeScope();

			builder.RegisterType<WorkOrderPhotoHistoryService>()
				.As<IWorkOrderPhotoHistoryService>().InstancePerLifetimeScope();

			builder.RegisterType<WorkOrderPhotoTempService>()
				.As<IWorkOrderPhotoTempService>().InstancePerLifetimeScope();

			builder.RegisterType<WorkOrderRatingService>()
				.As<IWorkOrderRatingService>().InstancePerLifetimeScope();

		}
	}
}


