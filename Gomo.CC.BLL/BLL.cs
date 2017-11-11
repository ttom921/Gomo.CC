






using Gomo.CC.IBLL;
using Gomo.CC.IDAL;
using Gomo.CC.Model;
namespace Gomo.CC.BLL
{

	public partial class AccountPayService:BaseService<AccountPay>,IAccountPayService
	{
		public AccountPayService(IAccountPayDal accountpaydal)
			:base(accountpaydal)
		{
		}
	}

	public partial class AccountReceivableService:BaseService<AccountReceivable>,IAccountReceivableService
	{
		public AccountReceivableService(IAccountReceivableDal accountreceivabledal)
			:base(accountreceivabledal)
		{
		}
	}

	public partial class AdDetailService:BaseService<AdDetail>,IAdDetailService
	{
		public AdDetailService(IAdDetailDal addetaildal)
			:base(addetaildal)
		{
		}
	}

	public partial class AdmanageService:BaseService<Admanage>,IAdmanageService
	{
		public AdmanageService(IAdmanageDal admanagedal)
			:base(admanagedal)
		{
		}
	}

	public partial class AdProfileService:BaseService<AdProfile>,IAdProfileService
	{
		public AdProfileService(IAdProfileDal adprofiledal)
			:base(adprofiledal)
		{
		}
	}

	public partial class AuthorityPointService:BaseService<AuthorityPoint>,IAuthorityPointService
	{
		public AuthorityPointService(IAuthorityPointDal authoritypointdal)
			:base(authoritypointdal)
		{
		}
	}

	public partial class AuthorityPointLogService:BaseService<AuthorityPointLog>,IAuthorityPointLogService
	{
		public AuthorityPointLogService(IAuthorityPointLogDal authoritypointlogdal)
			:base(authoritypointlogdal)
		{
		}
	}

	public partial class AutoMessageSetService:BaseService<AutoMessageSet>,IAutoMessageSetService
	{
		public AutoMessageSetService(IAutoMessageSetDal automessagesetdal)
			:base(automessagesetdal)
		{
		}
	}

	public partial class AutoMessageTypeService:BaseService<AutoMessageType>,IAutoMessageTypeService
	{
		public AutoMessageTypeService(IAutoMessageTypeDal automessagetypedal)
			:base(automessagetypedal)
		{
		}
	}

	public partial class BestAnswerVoteService:BaseService<BestAnswerVote>,IBestAnswerVoteService
	{
		public BestAnswerVoteService(IBestAnswerVoteDal bestanswervotedal)
			:base(bestanswervotedal)
		{
		}
	}

	public partial class BillsPayableService:BaseService<BillsPayable>,IBillsPayableService
	{
		public BillsPayableService(IBillsPayableDal billspayabledal)
			:base(billspayabledal)
		{
		}
	}

	public partial class ConsumerAccountService:BaseService<ConsumerAccount>,IConsumerAccountService
	{
		public ConsumerAccountService(IConsumerAccountDal consumeraccountdal)
			:base(consumeraccountdal)
		{
		}
	}

	public partial class ConsumerFaviorRepairShopService:BaseService<ConsumerFaviorRepairShop>,IConsumerFaviorRepairShopService
	{
		public ConsumerFaviorRepairShopService(IConsumerFaviorRepairShopDal consumerfaviorrepairshopdal)
			:base(consumerfaviorrepairshopdal)
		{
		}
	}

	public partial class ConsumerProfileService:BaseService<ConsumerProfile>,IConsumerProfileService
	{
		public ConsumerProfileService(IConsumerProfileDal consumerprofiledal)
			:base(consumerprofiledal)
		{
		}
	}

	public partial class ConsumerVehicleService:BaseService<ConsumerVehicle>,IConsumerVehicleService
	{
		public ConsumerVehicleService(IConsumerVehicleDal consumervehicledal)
			:base(consumervehicledal)
		{
		}
	}

	public partial class FaqcategoryService:BaseService<Faqcategory>,IFaqcategoryService
	{
		public FaqcategoryService(IFaqcategoryDal faqcategorydal)
			:base(faqcategorydal)
		{
		}
	}

	public partial class FaqlistService:BaseService<Faqlist>,IFaqlistService
	{
		public FaqlistService(IFaqlistDal faqlistdal)
			:base(faqlistdal)
		{
		}
	}

	public partial class ForumCategoryService:BaseService<ForumCategory>,IForumCategoryService
	{
		public ForumCategoryService(IForumCategoryDal forumcategorydal)
			:base(forumcategorydal)
		{
		}
	}

	public partial class ForumQuestionService:BaseService<ForumQuestion>,IForumQuestionService
	{
		public ForumQuestionService(IForumQuestionDal forumquestiondal)
			:base(forumquestiondal)
		{
		}
	}

	public partial class ForumReplyService:BaseService<ForumReply>,IForumReplyService
	{
		public ForumReplyService(IForumReplyDal forumreplydal)
			:base(forumreplydal)
		{
		}
	}

	public partial class GoodsAnswerService:BaseService<GoodsAnswer>,IGoodsAnswerService
	{
		public GoodsAnswerService(IGoodsAnswerDal goodsanswerdal)
			:base(goodsanswerdal)
		{
		}
	}

	public partial class GoodsListService:BaseService<GoodsList>,IGoodsListService
	{
		public GoodsListService(IGoodsListDal goodslistdal)
			:base(goodslistdal)
		{
		}
	}

	public partial class GoodsOrderService:BaseService<GoodsOrder>,IGoodsOrderService
	{
		public GoodsOrderService(IGoodsOrderDal goodsorderdal)
			:base(goodsorderdal)
		{
		}
	}

	public partial class GoodsOrderRatingService:BaseService<GoodsOrderRating>,IGoodsOrderRatingService
	{
		public GoodsOrderRatingService(IGoodsOrderRatingDal goodsorderratingdal)
			:base(goodsorderratingdal)
		{
		}
	}

	public partial class GoodsPhotoService:BaseService<GoodsPhoto>,IGoodsPhotoService
	{
		public GoodsPhotoService(IGoodsPhotoDal goodsphotodal)
			:base(goodsphotodal)
		{
		}
	}

	public partial class GoodsQuestionService:BaseService<GoodsQuestion>,IGoodsQuestionService
	{
		public GoodsQuestionService(IGoodsQuestionDal goodsquestiondal)
			:base(goodsquestiondal)
		{
		}
	}

	public partial class ImgFileService:BaseService<ImgFile>,IImgFileService
	{
		public ImgFileService(IImgFileDal imgfiledal)
			:base(imgfiledal)
		{
		}
	}

	public partial class ImgServerService:BaseService<ImgServer>,IImgServerService
	{
		public ImgServerService(IImgServerDal imgserverdal)
			:base(imgserverdal)
		{
		}
	}

	public partial class MessageNotifyService:BaseService<MessageNotify>,IMessageNotifyService
	{
		public MessageNotifyService(IMessageNotifyDal messagenotifydal)
			:base(messagenotifydal)
		{
		}
	}

	public partial class MessageRecordService:BaseService<MessageRecord>,IMessageRecordService
	{
		public MessageRecordService(IMessageRecordDal messagerecorddal)
			:base(messagerecorddal)
		{
		}
	}

	public partial class MessageTypeService:BaseService<MessageType>,IMessageTypeService
	{
		public MessageTypeService(IMessageTypeDal messagetypedal)
			:base(messagetypedal)
		{
		}
	}

	public partial class OrderInfoService:BaseService<OrderInfo>,IOrderInfoService
	{
		public OrderInfoService(IOrderInfoDal orderinfodal)
			:base(orderinfodal)
		{
		}
	}

	public partial class QuestionListService:BaseService<QuestionList>,IQuestionListService
	{
		public QuestionListService(IQuestionListDal questionlistdal)
			:base(questionlistdal)
		{
		}
	}

	public partial class RepairConsumerProfileService:BaseService<RepairConsumerProfile>,IRepairConsumerProfileService
	{
		public RepairConsumerProfileService(IRepairConsumerProfileDal repairconsumerprofiledal)
			:base(repairconsumerprofiledal)
		{
		}
	}

	public partial class RepairConsumerVehicleService:BaseService<RepairConsumerVehicle>,IRepairConsumerVehicleService
	{
		public RepairConsumerVehicleService(IRepairConsumerVehicleDal repairconsumervehicledal)
			:base(repairconsumervehicledal)
		{
		}
	}

	public partial class RepairShopAccountService:BaseService<RepairShopAccount>,IRepairShopAccountService
	{
		public RepairShopAccountService(IRepairShopAccountDal repairshopaccountdal)
			:base(repairshopaccountdal)
		{
		}
	}

	public partial class RepairShopInfoService:BaseService<RepairShopInfo>,IRepairShopInfoService
	{
		public RepairShopInfoService(IRepairShopInfoDal repairshopinfodal)
			:base(repairshopinfodal)
		{
		}
	}

	public partial class RepairShopInventoryService:BaseService<RepairShopInventory>,IRepairShopInventoryService
	{
		public RepairShopInventoryService(IRepairShopInventoryDal repairshopinventorydal)
			:base(repairshopinventorydal)
		{
		}
	}

	public partial class RepairShopInventoryTransactionService:BaseService<RepairShopInventoryTransaction>,IRepairShopInventoryTransactionService
	{
		public RepairShopInventoryTransactionService(IRepairShopInventoryTransactionDal repairshopinventorytransactiondal)
			:base(repairshopinventorytransactiondal)
		{
		}
	}

	public partial class RepairShopLaborService:BaseService<RepairShopLabor>,IRepairShopLaborService
	{
		public RepairShopLaborService(IRepairShopLaborDal repairshoplabordal)
			:base(repairshoplabordal)
		{
		}
	}

	public partial class RepairShopLaborCategoryService:BaseService<RepairShopLaborCategory>,IRepairShopLaborCategoryService
	{
		public RepairShopLaborCategoryService(IRepairShopLaborCategoryDal repairshoplaborcategorydal)
			:base(repairshoplaborcategorydal)
		{
		}
	}

	public partial class RepairShopLaborDefaultService:BaseService<RepairShopLaborDefault>,IRepairShopLaborDefaultService
	{
		public RepairShopLaborDefaultService(IRepairShopLaborDefaultDal repairshoplabordefaultdal)
			:base(repairshoplabordefaultdal)
		{
		}
	}

	public partial class RepairShopLaborTypeService:BaseService<RepairShopLaborType>,IRepairShopLaborTypeService
	{
		public RepairShopLaborTypeService(IRepairShopLaborTypeDal repairshoplabortypedal)
			:base(repairshoplabortypedal)
		{
		}
	}

	public partial class RepairShopPhotoService:BaseService<RepairShopPhoto>,IRepairShopPhotoService
	{
		public RepairShopPhotoService(IRepairShopPhotoDal repairshopphotodal)
			:base(repairshopphotodal)
		{
		}
	}

	public partial class RepairShopRatingService:BaseService<RepairShopRating>,IRepairShopRatingService
	{
		public RepairShopRatingService(IRepairShopRatingDal repairshopratingdal)
			:base(repairshopratingdal)
		{
		}
	}

	public partial class RepairShopSupplierService:BaseService<RepairShopSupplier>,IRepairShopSupplierService
	{
		public RepairShopSupplierService(IRepairShopSupplierDal repairshopsupplierdal)
			:base(repairshopsupplierdal)
		{
		}
	}

	public partial class RepairShopUserInfoService:BaseService<RepairShopUserInfo>,IRepairShopUserInfoService
	{
		public RepairShopUserInfoService(IRepairShopUserInfoDal repairshopuserinfodal)
			:base(repairshopuserinfodal)
		{
		}
	}

	public partial class ReplyListService:BaseService<ReplyList>,IReplyListService
	{
		public ReplyListService(IReplyListDal replylistdal)
			:base(replylistdal)
		{
		}
	}

	public partial class ReportCustCarService:BaseService<ReportCustCar>,IReportCustCarService
	{
		public ReportCustCarService(IReportCustCarDal reportcustcardal)
			:base(reportcustcardal)
		{
		}
	}

	public partial class ReportCustomerService:BaseService<ReportCustomer>,IReportCustomerService
	{
		public ReportCustomerService(IReportCustomerDal reportcustomerdal)
			:base(reportcustomerdal)
		{
		}
	}

	public partial class ReportCustOtherService:BaseService<ReportCustOther>,IReportCustOtherService
	{
		public ReportCustOtherService(IReportCustOtherDal reportcustotherdal)
			:base(reportcustotherdal)
		{
		}
	}

	public partial class ReportCustProdService:BaseService<ReportCustProd>,IReportCustProdService
	{
		public ReportCustProdService(IReportCustProdDal reportcustproddal)
			:base(reportcustproddal)
		{
		}
	}

	public partial class ReportCustSaleService:BaseService<ReportCustSale>,IReportCustSaleService
	{
		public ReportCustSaleService(IReportCustSaleDal reportcustsaledal)
			:base(reportcustsaledal)
		{
		}
	}

	public partial class ReportCustStaffService:BaseService<ReportCustStaff>,IReportCustStaffService
	{
		public ReportCustStaffService(IReportCustStaffDal reportcuststaffdal)
			:base(reportcuststaffdal)
		{
		}
	}

	public partial class ReportInvRecvService:BaseService<ReportInvRecv>,IReportInvRecvService
	{
		public ReportInvRecvService(IReportInvRecvDal reportinvrecvdal)
			:base(reportinvrecvdal)
		{
		}
	}

	public partial class ReportOrderCarService:BaseService<ReportOrderCar>,IReportOrderCarService
	{
		public ReportOrderCarService(IReportOrderCarDal reportordercardal)
			:base(reportordercardal)
		{
		}
	}

	public partial class ReportOrderDetailService:BaseService<ReportOrderDetail>,IReportOrderDetailService
	{
		public ReportOrderDetailService(IReportOrderDetailDal reportorderdetaildal)
			:base(reportorderdetaildal)
		{
		}
	}

	public partial class ReportOrderOtherService:BaseService<ReportOrderOther>,IReportOrderOtherService
	{
		public ReportOrderOtherService(IReportOrderOtherDal reportorderotherdal)
			:base(reportorderotherdal)
		{
		}
	}

	public partial class ReportOrderProdService:BaseService<ReportOrderProd>,IReportOrderProdService
	{
		public ReportOrderProdService(IReportOrderProdDal reportorderproddal)
			:base(reportorderproddal)
		{
		}
	}

	public partial class ReportOrderSaleService:BaseService<ReportOrderSale>,IReportOrderSaleService
	{
		public ReportOrderSaleService(IReportOrderSaleDal reportordersaledal)
			:base(reportordersaledal)
		{
		}
	}

	public partial class ReportOrderStaffService:BaseService<ReportOrderStaff>,IReportOrderStaffService
	{
		public ReportOrderStaffService(IReportOrderStaffDal reportorderstaffdal)
			:base(reportorderstaffdal)
		{
		}
	}

	public partial class ReportOverallService:BaseService<ReportOverall>,IReportOverallService
	{
		public ReportOverallService(IReportOverallDal reportoveralldal)
			:base(reportoveralldal)
		{
		}
	}

	public partial class ReportPartService:BaseService<ReportPart>,IReportPartService
	{
		public ReportPartService(IReportPartDal reportpartdal)
			:base(reportpartdal)
		{
		}
	}

	public partial class ReportSumaryService:BaseService<ReportSumary>,IReportSumaryService
	{
		public ReportSumaryService(IReportSumaryDal reportsumarydal)
			:base(reportsumarydal)
		{
		}
	}

	public partial class ReservationService:BaseService<Reservation>,IReservationService
	{
		public ReservationService(IReservationDal reservationdal)
			:base(reservationdal)
		{
		}
	}

	public partial class RoleInfoService:BaseService<RoleInfo>,IRoleInfoService
	{
		public RoleInfoService(IRoleInfoDal roleinfodal)
			:base(roleinfodal)
		{
		}
	}

	public partial class ShopAccountPayableService:BaseService<ShopAccountPayable>,IShopAccountPayableService
	{
		public ShopAccountPayableService(IShopAccountPayableDal shopaccountpayabledal)
			:base(shopaccountpayabledal)
		{
		}
	}

	public partial class ShopPackageDetailService:BaseService<ShopPackageDetail>,IShopPackageDetailService
	{
		public ShopPackageDetailService(IShopPackageDetailDal shoppackagedetaildal)
			:base(shoppackagedetaildal)
		{
		}
	}

	public partial class ShopPackageMainService:BaseService<ShopPackageMain>,IShopPackageMainService
	{
		public ShopPackageMainService(IShopPackageMainDal shoppackagemaindal)
			:base(shoppackagemaindal)
		{
		}
	}

	public partial class ShopPartsTypeService:BaseService<ShopPartsType>,IShopPartsTypeService
	{
		public ShopPartsTypeService(IShopPartsTypeDal shoppartstypedal)
			:base(shoppartstypedal)
		{
		}
	}

	public partial class ShopPartsTypeCategoryService:BaseService<ShopPartsTypeCategory>,IShopPartsTypeCategoryService
	{
		public ShopPartsTypeCategoryService(IShopPartsTypeCategoryDal shoppartstypecategorydal)
			:base(shoppartstypecategorydal)
		{
		}
	}

	public partial class ShopPartsTypeDefaultService:BaseService<ShopPartsTypeDefault>,IShopPartsTypeDefaultService
	{
		public ShopPartsTypeDefaultService(IShopPartsTypeDefaultDal shoppartstypedefaultdal)
			:base(shoppartstypedefaultdal)
		{
		}
	}

	public partial class ShopStaffProfileService:BaseService<ShopStaffProfile>,IShopStaffProfileService
	{
		public ShopStaffProfileService(IShopStaffProfileDal shopstaffprofiledal)
			:base(shopstaffprofiledal)
		{
		}
	}

	public partial class ShopWorkOrderService:BaseService<ShopWorkOrder>,IShopWorkOrderService
	{
		public ShopWorkOrderService(IShopWorkOrderDal shopworkorderdal)
			:base(shopworkorderdal)
		{
		}
	}

	public partial class ShopWorkOrderHistoryService:BaseService<ShopWorkOrderHistory>,IShopWorkOrderHistoryService
	{
		public ShopWorkOrderHistoryService(IShopWorkOrderHistoryDal shopworkorderhistorydal)
			:base(shopworkorderhistorydal)
		{
		}
	}

	public partial class ShopWorkOrderTempService:BaseService<ShopWorkOrderTemp>,IShopWorkOrderTempService
	{
		public ShopWorkOrderTempService(IShopWorkOrderTempDal shopworkordertempdal)
			:base(shopworkordertempdal)
		{
		}
	}

	public partial class TechAskCategoryService:BaseService<TechAskCategory>,ITechAskCategoryService
	{
		public TechAskCategoryService(ITechAskCategoryDal techaskcategorydal)
			:base(techaskcategorydal)
		{
		}
	}

	public partial class TechAskQuestionService:BaseService<TechAskQuestion>,ITechAskQuestionService
	{
		public TechAskQuestionService(ITechAskQuestionDal techaskquestiondal)
			:base(techaskquestiondal)
		{
		}
	}

	public partial class TechAskReplyService:BaseService<TechAskReply>,ITechAskReplyService
	{
		public TechAskReplyService(ITechAskReplyDal techaskreplydal)
			:base(techaskreplydal)
		{
		}
	}

	public partial class UserGuideService:BaseService<UserGuide>,IUserGuideService
	{
		public UserGuideService(IUserGuideDal userguidedal)
			:base(userguidedal)
		{
		}
	}

	public partial class UserInfoService:BaseService<UserInfo>,IUserInfoService
	{
		public UserInfoService(IUserInfoDal userinfodal)
			:base(userinfodal)
		{
		}
	}

	public partial class UserInfoParentService:BaseService<UserInfoParent>,IUserInfoParentService
	{
		public UserInfoParentService(IUserInfoParentDal userinfoparentdal)
			:base(userinfoparentdal)
		{
		}
	}

	public partial class UserInfoRoleInfoService:BaseService<UserInfoRoleInfo>,IUserInfoRoleInfoService
	{
		public UserInfoRoleInfoService(IUserInfoRoleInfoDal userinforoleinfodal)
			:base(userinforoleinfodal)
		{
		}
	}

	public partial class VehicleCategoryService:BaseService<VehicleCategory>,IVehicleCategoryService
	{
		public VehicleCategoryService(IVehicleCategoryDal vehiclecategorydal)
			:base(vehiclecategorydal)
		{
		}
	}

	public partial class VehicleModelService:BaseService<VehicleModel>,IVehicleModelService
	{
		public VehicleModelService(IVehicleModelDal vehiclemodeldal)
			:base(vehiclemodeldal)
		{
		}
	}

	public partial class VehicleTypeService:BaseService<VehicleType>,IVehicleTypeService
	{
		public VehicleTypeService(IVehicleTypeDal vehicletypedal)
			:base(vehicletypedal)
		{
		}
	}

	public partial class WebDriverAccessLogService:BaseService<WebDriverAccessLog>,IWebDriverAccessLogService
	{
		public WebDriverAccessLogService(IWebDriverAccessLogDal webdriveraccesslogdal)
			:base(webdriveraccesslogdal)
		{
		}
	}

	public partial class WebTwshopAccessLogService:BaseService<WebTwshopAccessLog>,IWebTwshopAccessLogService
	{
		public WebTwshopAccessLogService(IWebTwshopAccessLogDal webtwshopaccesslogdal)
			:base(webtwshopaccesslogdal)
		{
		}
	}

	public partial class WorkOrderAskService:BaseService<WorkOrderAsk>,IWorkOrderAskService
	{
		public WorkOrderAskService(IWorkOrderAskDal workorderaskdal)
			:base(workorderaskdal)
		{
		}
	}

	public partial class WorkOrderDetailService:BaseService<WorkOrderDetail>,IWorkOrderDetailService
	{
		public WorkOrderDetailService(IWorkOrderDetailDal workorderdetaildal)
			:base(workorderdetaildal)
		{
		}
	}

	public partial class WorkOrderDetailHistoryService:BaseService<WorkOrderDetailHistory>,IWorkOrderDetailHistoryService
	{
		public WorkOrderDetailHistoryService(IWorkOrderDetailHistoryDal workorderdetailhistorydal)
			:base(workorderdetailhistorydal)
		{
		}
	}

	public partial class WorkOrderDetailTempService:BaseService<WorkOrderDetailTemp>,IWorkOrderDetailTempService
	{
		public WorkOrderDetailTempService(IWorkOrderDetailTempDal workorderdetailtempdal)
			:base(workorderdetailtempdal)
		{
		}
	}

	public partial class WorkOrderPhotoService:BaseService<WorkOrderPhoto>,IWorkOrderPhotoService
	{
		public WorkOrderPhotoService(IWorkOrderPhotoDal workorderphotodal)
			:base(workorderphotodal)
		{
		}
	}

	public partial class WorkOrderPhotoHistoryService:BaseService<WorkOrderPhotoHistory>,IWorkOrderPhotoHistoryService
	{
		public WorkOrderPhotoHistoryService(IWorkOrderPhotoHistoryDal workorderphotohistorydal)
			:base(workorderphotohistorydal)
		{
		}
	}

	public partial class WorkOrderPhotoTempService:BaseService<WorkOrderPhotoTemp>,IWorkOrderPhotoTempService
	{
		public WorkOrderPhotoTempService(IWorkOrderPhotoTempDal workorderphototempdal)
			:base(workorderphototempdal)
		{
		}
	}

	public partial class WorkOrderRatingService:BaseService<WorkOrderRating>,IWorkOrderRatingService
	{
		public WorkOrderRatingService(IWorkOrderRatingDal workorderratingdal)
			:base(workorderratingdal)
		{
		}
	}

}


