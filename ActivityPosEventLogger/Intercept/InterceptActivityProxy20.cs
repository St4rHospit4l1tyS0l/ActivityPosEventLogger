using LasaActivity;

namespace ActivityPosEventLogger.Intercept
{
    public partial class InterceptActivityProxy
    {
        void IInterceptAlohaActivity20.AcceptTable(int employeeId, int fromTableId, int toTableId)
        {
            _service.AcceptTable(employeeId, fromTableId, toTableId);
        }

        void IInterceptAlohaActivity20.ActivatePinPad(int termId)
        {
            _service.ActivatePinPad(termId);
        }

        void IInterceptAlohaActivity20.AddDeferredModifier(int employeeId, int queueId, int tableId, int checkId, int parentEntryId, int modGroupId, string modGroupName)
        {
            _service.AddDeferredModifier(employeeId, queueId, tableId, checkId, parentEntryId, modGroupId, modGroupName);
        }

        void IInterceptAlohaActivity20.AddItem(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.AddItem(employeeId, queueId, tableId, checkId, entryId);
        }

        void IInterceptAlohaActivity20.AddTab(int employeeId, int fromTableId, int toTableId)
        {
            _service.AddTab(employeeId, fromTableId, toTableId);
        }

        void IInterceptAlohaActivity20.AdjustPayment(int managerId, int employeeId, int queueId, int tableId, int checkId, int tenderId, int paymentId)
        {
            _service.AdjustPayment(managerId, employeeId, queueId, tableId, checkId, tenderId, paymentId);
        }

        void IInterceptAlohaActivity20.AdvanceOrder(int employeeId, int queueId, int tableId)
        {
            _service.AdvanceOrder(employeeId, queueId, tableId);
        }

        void IInterceptAlohaActivity20.ApplyComp(int managerId, int employeeId, int queueId, int tableId, int checkId, int compTypeId, int compId)
        {
            _service.ApplyComp(managerId, employeeId, queueId, tableId, checkId, compTypeId, compId);
        }

        void IInterceptAlohaActivity20.ApplyPayment(int managerId, int employeeId, int queueId, int tableId, int checkId, int tenderId, int paymentId)
        {
            _service.ApplyPayment(managerId, employeeId, queueId, tableId, checkId, tenderId, paymentId);
        }

        void IInterceptAlohaActivity20.ApplyPromo(int managerId, int employeeId, int queueId, int tableId, int checkId, int promotionId, int promoId)
        {
            _service.ApplyPromo(managerId, employeeId, queueId, tableId, checkId, promotionId, promoId);
        }

        void IInterceptAlohaActivity20.AssignCashDrawer(int employeeId, int drawerId, int isPublic)
        {
            _service.AssignCashDrawer(employeeId, drawerId, isPublic);
        }

        void IInterceptAlohaActivity20.AuthorizePayment(int tableId, int checkId, int paymentId, int transactionType, int transactionResult)
        {
            _service.AuthorizePayment(tableId, checkId, paymentId, transactionType, transactionResult);
        }

        void IInterceptAlohaActivity20.BeginLogMergeByMaster(int masterTermId, int mergedTermId, string fileServerName)
        {
            _service.BeginLogMergeByMaster(masterTermId, mergedTermId, fileServerName);
        }

        void IInterceptAlohaActivity20.BeginTransaction(int termId, string txnKey, int employeeId, double amount, double tip)
        {
            _service.BeginTransaction(termId, txnKey, employeeId, amount, tip);
        }

        void IInterceptAlohaActivity20.Bump(int tableId)
        {
            _service.Bump(tableId);
        }

        void IInterceptAlohaActivity20.CancelAddItem(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.CancelAddItem(employeeId, queueId, tableId, checkId, entryId);
        }

        void IInterceptAlohaActivity20.CancelTransaction(int termId)
        {
            _service.CancelTransaction(termId);
        }

        void IInterceptAlohaActivity20.CarryoverId(int type, int oldId, int newId)
        {
            _service.CarryoverId(type, oldId, newId);
        }

        void IInterceptAlohaActivity20.ChangeItemSize(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.ChangeItemSize(employeeId, queueId, tableId, checkId, entryId);
        }

        void IInterceptAlohaActivity20.ClockIn(int employeeId, string empName, int jobcodeId, string jobName)
        {
            _service.ClockIn(employeeId, empName, jobcodeId, jobName);
        }

        void IInterceptAlohaActivity20.ClockOut(int employeeId, string empName)
        {
            _service.ClockOut(employeeId, empName);
        }

        void IInterceptAlohaActivity20.CloseCheck(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.CloseCheck(employeeId, queueId, tableId, checkId);
        }

        void IInterceptAlohaActivity20.CloseTable(int employeeId, int queueId, int tableId)
        {
            _service.CloseTable(employeeId, queueId, tableId);
        }

        void IInterceptAlohaActivity20.CombineOrder(int employeeId, int srcQueueId, int srcTableId, int srcCheckId, int dstQueueId, int dstTableId, int dstCheckId)
        {
            _service.CombineOrder(employeeId, srcQueueId, srcTableId, srcCheckId, dstQueueId, dstTableId, dstCheckId);
        }

        void IInterceptAlohaActivity20.CurrentCheckChanged(int termId, int tableId, int checkId)
        {
            _service.CurrentCheckChanged(termId, tableId, checkId);
        }

        void IInterceptAlohaActivity20.Custom(string name)
        {
            _service.Custom(name);
        }

        void IInterceptAlohaActivity20.DeassignCashDrawer(int employeeId, int drawerId, int isPublic)
        {
            _service.DeassignCashDrawer(employeeId, drawerId, isPublic);
        }

        void IInterceptAlohaActivity20.DeleteComp(int managerId, int employeeId, int queueId, int tableId, int checkId, int compTypeId, int compId)
        {
            _service.DeleteComp(managerId, employeeId, queueId, tableId, checkId, compTypeId, compId);
        }

        void IInterceptAlohaActivity20.DeleteItems(int managerId, int employeeId, int queueId, int tableId, int checkId, int reasonId)
        {
            _service.DeleteItems(managerId, employeeId, queueId, tableId, checkId, reasonId);
        }

        void IInterceptAlohaActivity20.DeleteLoyaltyMember(int checkId, string loyaltyCardNumber)
        {
            _service.DeleteLoyaltyMember(checkId, loyaltyCardNumber);
        }

        void IInterceptAlohaActivity20.DeletePayment(int managerId, int employeeId, int queueId, int tableId, int checkId, int tenderId, int paymentId)
        {
            _service.DeletePayment(managerId, employeeId, queueId, tableId, checkId, tenderId, paymentId);
        }

        void IInterceptAlohaActivity20.DeletePromo(int managerId, int employeeId, int queueId, int tableId, int checkId, int promotionId, int promoId)
        {
            _service.DeletePromo(managerId, employeeId, queueId, tableId, checkId, promotionId, promoId);
        }

        void IInterceptAlohaActivity20.DisplayBankResponseMessages(int termId, string bankResponse)
        {
            _service.DisplayBankResponseMessages(termId, bankResponse);
        }

        void IInterceptAlohaActivity20.EndOfDay(int isMaster)
        {
            _service.EndOfDay(isMaster);
        }

        void IInterceptAlohaActivity20.EnrollEmployee(int employeeId, int numTries)
        {
            _service.EnrollEmployee(employeeId, numTries);
        }

        void IInterceptAlohaActivity20.EnterIberScreen(int termId, int screenId)
        {
            _service.EnterIberScreen(termId, screenId);
        }

        void IInterceptAlohaActivity20.EventNotification(int employeeId, int tableId, ALOHA_ACTIVITY_EVENT_NOTIFICATION_TYPES eventNotification)
        {
            _service.EventNotification(employeeId, tableId, eventNotification);
        }

        void IInterceptAlohaActivity20.ExitIberScreen(int termId, int screenId)
        {
            _service.ExitIberScreen(termId, screenId);
        }

        void IInterceptAlohaActivity20.FileServer(string serverName)
        {
            _service.FileServer(serverName);
        }

        void IInterceptAlohaActivity20.FileServerDown()
        {
            _service.FileServerDown();
        }

        void IInterceptAlohaActivity20.FinalBump(int tableId)
        {
            _service.FinalBump(tableId);
        }

        void IInterceptAlohaActivity20.GenericPinPadCommand(int termId, string input)
        {
            _service.GenericPinPadCommand(termId, input);
        }

        void IInterceptAlohaActivity20.HoldItems(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.HoldItems(employeeId, queueId, tableId, checkId);
        }

        void IInterceptAlohaActivity20.IAmMaster()
        {
            _service.AmMaster();
        }

        void IInterceptAlohaActivity20.InitializationComplete()
        {
            _service.InitializationComplete();
        }

        void IInterceptAlohaActivity20.KitchenOrderStatus(string orders)
        {
            _service.KitchenOrderStatus(orders);
        }

        void IInterceptAlohaActivity20.LockOrder(int tableId)
        {
            _service.LockOrder(tableId);
        }

        void IInterceptAlohaActivity20.LogIn(int employeeId, string name)
        {
            _service.LogIn(employeeId, name);
        }

        void IInterceptAlohaActivity20.LogMergedByMaster(int masterTermId, int mergedTermId, string fileServerName)
        {
            _service.LogMergedByMaster(masterTermId, mergedTermId, fileServerName);
        }

        void IInterceptAlohaActivity20.LogOut(int employeeId, string name)
        {
            _service.LogOut(employeeId, name);
        }

        void IInterceptAlohaActivity20.MasterDown()
        {
            _service.MasterDown();
        }

        void IInterceptAlohaActivity20.MasterSyncedMyLog(int localTermId, int masterTermId, string fileServerName)
        {
            _service.MasterSyncedMyLog(localTermId, masterTermId, fileServerName);
        }

        void IInterceptAlohaActivity20.ModifyItem(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.ModifyItem(employeeId, queueId, tableId, checkId, entryId);
        }

        void IInterceptAlohaActivity20.NameOrder(int employeeId, int queueId, int tableId, string name, int checkId)
        {
            _service.NameOrder(employeeId, queueId, tableId, name, checkId);
        }

        void IInterceptAlohaActivity20.NameOrder(int employeeId, int queueId, int tableId, string name)
        {
            _service.NameOrder(employeeId, queueId, tableId, name);
        }

        void IInterceptAlohaActivity20.OnClockTick()
        {
            _service.OnClockTick();
        }

        void IInterceptAlohaActivity20.OpenCheck(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.OpenCheck(employeeId, queueId, tableId, checkId);
        }

        void IInterceptAlohaActivity20.OpenItem(int employeeId, int entryId, int itemId, string description, double price)
        {
            _service.OpenItem(employeeId, entryId, itemId, description, price);
        }

        void IInterceptAlohaActivity20.OpenTable(int employeeId, int queueId, int tableId, int tableDefId, string name)
        {
            _service.OpenTable(employeeId, queueId, tableId, tableDefId, name);
        }

        void IInterceptAlohaActivity20.OrderItems(int employeeId, int queueId, int tableId, int checkId, int modeId)
        {
            _service.OrderItems(employeeId, queueId, tableId, checkId, modeId);
        }

        void IInterceptAlohaActivity20.OrderScreen_TableCheckSeatChanged(int managerId, int employeeId, int queueId, int tableId, int checkId, int seatNum)
        {
            _service.OrderScreen_TableCheckSeatChanged(managerId, employeeId, queueId, tableId, checkId, seatNum);
        }

        void IInterceptAlohaActivity20.PostDeleteComp(int managerId, int employeeId, int queueId, int tableId, int checkId, int compTypeId, int compId)
        {
            _service.PostDeleteComp(managerId, employeeId, queueId, tableId, checkId, compTypeId, compId);
        }

        void IInterceptAlohaActivity20.PostDeleteItems(int managerId, int employeeId, int queueId, int tableId, int checkId, int reasonId)
        {
            _service.PostDeleteItems(managerId, employeeId, queueId, tableId, checkId, reasonId);
        }

        void IInterceptAlohaActivity20.PostDeletePromo(int managerId, int employeeId, int queueId, int tableId, int checkId, int promotionId, int promoId)
        {
            _service.PostDeletePromo(managerId, employeeId, queueId, tableId, checkId, promotionId, promoId);
        }

        void IInterceptAlohaActivity20.PostLockOrder(int termId)
        {
            _service.PostLockOrder(termId);
        }

        void IInterceptAlohaActivity20.PostUnlockOrder(int termId)
        {
            _service.PostUnlockOrder(termId);
        }

        void IInterceptAlohaActivity20.PreModifyItem(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.PreModifyItem(employeeId, queueId, tableId, checkId, entryId);
        }

        void IInterceptAlohaActivity20.ReassignCashDrawer(int employeeId, int drawerId)
        {
            _service.ReassignCashDrawer(employeeId, drawerId);
        }

        void IInterceptAlohaActivity20.RemoveDeferredModifier(int employeeId, int queueId, int tableId, int checkId, int parentEntryId, int modGroupId)
        {
            _service.RemoveDeferredModifier(employeeId, queueId, tableId, checkId, parentEntryId, modGroupId);
        }

        void IInterceptAlohaActivity20.RenameTab(int termId, int checkId, string tabName)
        {
            _service.RenameTab(termId, checkId, tabName);
        }

        void IInterceptAlohaActivity20.ReopenCheck(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.ReopenCheck(employeeId, queueId, tableId, checkId);
        }

        void IInterceptAlohaActivity20.ReqMasterToSyncMyLog(int localTermId, int masterTermId, string fileServerName)
        {
            _service.ReqMasterToSyncMyLog(localTermId, masterTermId, fileServerName);
        }

        void IInterceptAlohaActivity20.RerouteDisplayBoard(int employeeId, int queueId, int tableId, int checkId, int displayBoardId, int controllingTerminalId, int defaultOrderModeOverride, int currentOrderOnly)
        {
            _service.RerouteDisplayBoard(employeeId, queueId, tableId, checkId, displayBoardId, controllingTerminalId, defaultOrderModeOverride, currentOrderOnly);
        }

        void IInterceptAlohaActivity20.ResetPinPad(int termId)
        {
            _service.ResetPinPad(termId);
        }

        void IInterceptAlohaActivity20.SaveTab(int employeeId, int tableId, string name)
        {
            _service.SaveTab(employeeId, tableId, name);
        }

        void IInterceptAlohaActivity20.SetMasterTerminal(int terminalId)
        {
            _service.SetMasterTerminal(terminalId);
        }

        void IInterceptAlohaActivity20.SetQuickComboLevel(int employeeId, int queueId, int tableId, int checkId, int promotionId, int promoId, int nLevel, int nContext)
        {
            _service.SetQuickComboLevel(employeeId, queueId, tableId, checkId, promotionId, promoId, nLevel, nContext);
        }

        void IInterceptAlohaActivity20.SettleInfoChanged(string settleInfo)
        {
            _service.SettleInfoChanged(settleInfo);
        }

        void IInterceptAlohaActivity20.Shutdown()
        {
            _service.Shutdown();
        }

        void IInterceptAlohaActivity20.SpecialMessage(int employeeId, int messageId, string message)
        {
            _service.SpecialMessage(employeeId, messageId, message);
        }

        void IInterceptAlohaActivity20.SplitCheck(int checkId, int tableId, int queueId, int employeeNumber, int numberOfSplits, int splitType)
        {
            _service.SplitCheck(checkId, tableId, queueId, employeeNumber, numberOfSplits, splitType);
        }

        void IInterceptAlohaActivity20.SpoolMode(int termId, int spoolMode)
        {
            _service.SpoolMode(termId, spoolMode);
        }

        void IInterceptAlohaActivity20.StartAddItem(int employeeId, int queueId, int tableId, int checkId, int entryId, int parentEntryId, int modCodeId, int itemId, string itemName, double itemPrice)
        {
            _service.StartAddItem(employeeId, queueId, tableId, checkId, entryId, parentEntryId, modCodeId, itemId, itemName, itemPrice);
        }

        void IInterceptAlohaActivity20.Startup(int hMainWnd)
        {
            _service.Startup(hMainWnd);
        }

        void IInterceptAlohaActivity20.TableToShowOnDispBChanged(int nTermId, int tableId)
        {
            _service.TableToShowOnDispBChanged(nTermId, tableId);
        }

        void IInterceptAlohaActivity20.TransferTable(int fromEmployeeId, int toEmployeeId, int tableId, string newName, int isGetCheck)
        {
            _service.TransferTable(fromEmployeeId, toEmployeeId, tableId, newName, isGetCheck);
        }

        void IInterceptAlohaActivity20.UnlockOrder(int tableId)
        {
            _service.UnlockOrder(tableId);
        }

        void IInterceptAlohaActivity20.UpdateDisplayBoard(int displayBoardId, int terminalId, int checkId)
        {
            _service.UpdateDisplayBoard(displayBoardId, terminalId, checkId);
        }

        void IInterceptAlohaActivity20.UpdateItems(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.UpdateItems(employeeId, queueId, tableId, checkId);
        }

    }
}
