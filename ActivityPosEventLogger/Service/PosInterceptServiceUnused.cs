using LasaActivity;

namespace ActivityPosEventLogger.Service
{
    public partial class PosInterceptService
    {
        public void ActivatePinPad(int termId)
        {
        }

        public void AddDeferredModifier(int employeeId, int queueId, int tableId, int checkId, int parentEntryId, int modGroupId, string modGroupName)
        {
        }

        public void ClockIn(int iEmployeeId, string sEmpName, int iJobcodeId, string sJobName)
        {

        }

        public void ClockOut(int iEmployeeId, string sEmpName)
        {

        }

        public void OpenTable(int iEmployeeId, int iQueueId, int iTableId, int iTableDefId, string sName)
        {
        }

        public void CloseTable(int iemployeeId, int iqueueId, int itableId)
        {

        }

        public void TransferTable(int ifromEmployeeId, int itoEmployeeId, int itableId, string sNewName, int iIsGetCheck)
        {

        }

        public void AcceptTable(int iemployeeId, int ifromTableId, int itoTableId)
        {

        }

        public void SaveTab(int iemployeeId, int itableId, string sName)
        {

        }

        public void AddTab(int iemployeeId, int ifromTableId, int itoTableId)
        {

        }

        public void NameOrder(int iemployeeId, int iqueueId, int itableId, string sName)
        {

        }
        public void NameOrder(int iEmployeeId, int iQueueId, int iTableId, string sName, int iCheckId)
        {

        }

        public void Bump(int iTableId)
        {

        }

        public void ModifyItem(int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iEntryId)
        {

        }

        public void OrderItems(int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iModeId)
        {

        }

        public void HoldItems(int iEmployeeId, int iQueueId, int iTableId, int iCheckId)
        {

        }

        public void OpenItem(int iEmployeeId, int iEntryId, int iItemId, string sDescription, double dPrice)
        {

        }

        public void SpecialMessage(int iEmployeeId, int iMessageId, string sMessage)
        {

        }

        public void DeleteItems(int iManagerId, int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iReasonId)
        {

        }

        public void UpdateItems(int iEmployeeId, int iQueueId, int iTableId, int iCheckId)
        {

        }

        public void ApplyPayment(int iManagerId, int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iTenderId, int iPaymentId)
        {

        }

        public void AdjustPayment(int iManagerId, int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iTenderId, int iPaymentId)
        {

        }

        public void DeletePayment(int iManagerId, int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iTenderId, int iPaymentId)
        {

        }

        public void ApplyComp(int iManagerId, int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iCompTypeId, int iCompId)
        {

        }

        public void DeleteComp(int iManagerId, int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iCompTypeId, int iCompId)
        {

        }

        public void ApplyPromo(int iManagerId, int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iPromotionId, int iPromoId)
        {

        }

        public void DeletePromo(int iManagerId, int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iPromotionId, int iPromoId)
        {

        }

        public void Custom(string sName)
        {

        }

        public void Startup(int iHMainWnd)
        {

        }

        public void Shutdown()
        {

        }

        public void CarryoverId(int iType, int iOldId, int iNewId)
        {

        }

        public void EndOfDay(int iIsMaster)
        {

        }

        public void CombineOrder(int iEmployeeId, int iSrcQueueId, int iSrcTableId, int iSrcCheckId, int iDstQueueId, int iDstTableId, int iDstCheckId)
        {

        }

        public void OnClockTick()
        {

        }

        public void PreModifyItem(int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iEntryId)
        {

        }

        public void LockOrder(int iTableId)
        {

        }

        public void UnlockOrder(int iTableId)
        {

        }

        public void SetMasterTerminal(int iTerminalId)
        {

        }

        public void SetQuickComboLevel(int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iPromotionId, int iPromoId, int iLevel, int iContext)
        {

        }

        public void TableToShowOnDispBChanged(int iTermId, int iTableId)
        {

        }

        public void StartAddItem(int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iEntryId, int iParentEntryId, int iModCodeId, int iItemId, string sItemName, double dItemPrice)
        {

        }

        public void CancelAddItem(int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iEntryId)
        {

        }

        public void PostDeleteItems(int iManagerId, int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iReasonId)
        {

        }

        public void PostDeleteComp(int iManagerId, int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iCompTypeId, int iCompId)
        {

        }

        public void PostDeletePromo(int iManagerId, int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iPromotionId, int iPromoId)
        {

        }

        public void OrderScreenTableCheckSeatChanged(int iManagerId, int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iSeatNum)
        {

        }

        public void EventNotification(int iEmployeeId, int iTableId, ALOHA_ACTIVITY_EVENT_NOTIFICATION_TYPES eventNotification)
        {

        }

        public void RerouteDisplayBoard(int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iDisplayBoardId, int iControllingTerminalId, int iDefaultOrderModeOverride, int currentOrderOnly)
        {

        }

        public void ChangeItemSize(int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iEntryId)
        {

        }

        public void AdvanceOrder(int iEmployeeId, int iQueueId, int iTableId)
        {

        }

        public void EnrollEmployee(int iEmployeeId, int iNumTries)
        {

        }

        public void MasterDown()
        {

        }

        public void AmMaster()
        {

        }

        public void FileServerDown()
        {

        }

        public void FileServer(string sServerName)
        {

        }

        public void SettleInfoChanged(string sSettleInfo)
        {

        }

        public void SplitCheck(int iCheckId, int iTableId, int iQueueId, int iEmployeeNumber, int iNumberOfSplits, int iSplitType)
        {

        }

        public void AuthorizePayment(int iTableId, int iCheckId, int iPaymentId, int iTransactionType, int iTransactionResult)
        {

        }

        public void CurrentCheckChanged(int iTermId, int iTableId, int iCheckId)
        {

        }

        public void FinalBump(int iTableId)
        {

        }

        public void AssignCashDrawer(int iEmployeeId, int iDrawerId, int iIsPublic)
        {

        }

        public void ReassignCashDrawer(int iEmployeeId, int iDrawerId)
        {

        }

        public void DeassignCashDrawer(int iEmployeeId, int iDrawerId, int iIsPublic)
        {

        }

        public void ReopenCheck(int iEmployeeId, int iQueueId, int iTableId, int iCheckId)
        {

        }

        public void EnterIberScreen(int iTermId, int iScreenId)
        {

        }

        public void ExitIberScreen(int iTermId, int iScreenId)
        {

        }

        public void IamMaster()
        {

        }

        public void XOpenCheck(int employeeId, int queueId, int tableId, int checkId)
        {

        }

        public void KitchenOrderStatus(string sOrders)
        {

        }

        public void RenameTab(int iTermId, int iCheckId, string stabName)
        {

        }

        public void BeginLogMergeByMaster(int masterTermId, int mergedTermId, string fileServerName)
        {
        }

        public void BeginTransaction(int termId, string txnKey, int employeeId, double amount, double tip)
        {
            
        }

        public void CancelTransaction(int termId)
        {
            
        }

        public void DeleteLoyaltyMember(int checkId, string loyaltyCardNumber)
        {
            
        }

        public void DisplayBankResponseMessages(int termId, string bankResponse)
        {
            
        }

        public void GenericPinPadCommand(int termId, string input)
        {
            
        }

        public void LogMergedByMaster(int masterTermId, int mergedTermId, string fileServerName)
        {
            
        }

        public void MasterSyncedMyLog(int localTermId, int masterTermId, string fileServerName)
        {
            
        }

        public void OrderScreen_TableCheckSeatChanged(int managerId, int employeeId, int queueId, int tableId, int checkId, int seatNum)
        {
            
        }

        public void PostLockOrder(int termId)
        {
            
        }

        public void PostUnlockOrder(int termId)
        {
            
        }

        public void RemoveDeferredModifier(int employeeId, int queueId, int tableId, int checkId, int parentEntryId, int modGroupId)
        {
            
        }

        public void ReqMasterToSyncMyLog(int localTermId, int masterTermId, string fileServerName)
        {
            
        }

        public void ResetPinPad(int termId)
        {
            
        }

        public void SpoolMode(int termId, int spoolMode)
        {
            
        }

        public void UpdateDisplayBoard(int displayBoardId, int terminalId, int checkId)
        {
            
        }
    }
}
