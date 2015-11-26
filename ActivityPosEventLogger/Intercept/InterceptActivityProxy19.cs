using LasaActivity;

namespace ActivityPosEventLogger.Intercept
{
    public partial class InterceptActivityProxy
    {
        void IInterceptAlohaActivity19.AcceptTable(int employeeId, int fromTableId, int toTableId)
        {
            _service.AcceptTable(employeeId, fromTableId, toTableId);
        }

        void IInterceptAlohaActivity19.AddDeferredModifier(int employeeId, int queueId, int tableId, int checkId, int parentEntryId, int modGroupId, string modGroupName)
        {
            _service.AddDeferredModifier(employeeId, queueId, tableId, checkId, parentEntryId, modGroupId, modGroupName);
        }

        void IInterceptAlohaActivity19.AddItem(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.AddItem(employeeId, queueId, tableId, checkId, entryId);
        }

        void IInterceptAlohaActivity19.AddTab(int employeeId, int fromTableId, int toTableId)
        {
            _service.AddTab(employeeId, fromTableId, toTableId);
        }

        void IInterceptAlohaActivity19.AdjustPayment(int managerId, int employeeId, int queueId, int tableId, int checkId, int tenderId, int paymentId)
        {
            _service.AdjustPayment(managerId, employeeId, queueId, tableId, checkId, tenderId, paymentId);
        }

        void IInterceptAlohaActivity19.AdvanceOrder(int employeeId, int queueId, int tableId)
        {
            _service.AdvanceOrder(employeeId, queueId, tableId);
        }

        void IInterceptAlohaActivity19.ApplyComp(int managerId, int employeeId, int queueId, int tableId, int checkId, int compTypeId, int compId)
        {
            _service.ApplyComp(managerId, employeeId, queueId, tableId, checkId, compTypeId, compId);
        }

        void IInterceptAlohaActivity19.ApplyPayment(int managerId, int employeeId, int queueId, int tableId, int checkId, int tenderId, int paymentId)
        {
            _service.ApplyPayment(managerId, employeeId, queueId, tableId, checkId, tenderId, paymentId);
        }

        void IInterceptAlohaActivity19.ApplyPromo(int managerId, int employeeId, int queueId, int tableId, int checkId, int promotionId, int promoId)
        {
            _service.ApplyPromo(managerId, employeeId, queueId, tableId, checkId, promotionId, promoId);
        }

        void IInterceptAlohaActivity19.AssignCashDrawer(int employeeId, int drawerId, int isPublic)
        {
            _service.AssignCashDrawer(employeeId, drawerId, isPublic);
        }

        void IInterceptAlohaActivity19.AuthorizePayment(int tableId, int checkId, int paymentId, int transactionType, int transactionResult)
        {
            _service.AuthorizePayment(tableId, checkId, paymentId, transactionType, transactionResult);
        }

        void IInterceptAlohaActivity19.BeginLogMergeByMaster(int masterTermId, int mergedTermId, string fileServerName)
        {
            _service.BeginLogMergeByMaster(masterTermId, mergedTermId, fileServerName);
        }


        void IInterceptAlohaActivity19.Bump(int tableId)
        {
            _service.Bump(tableId);
        }

        void IInterceptAlohaActivity19.CancelAddItem(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.CancelAddItem(employeeId, queueId, tableId, checkId, entryId);
        }


        void IInterceptAlohaActivity19.CarryoverId(int type, int oldId, int newId)
        {
            _service.CarryoverId(type, oldId, newId);
        }

        void IInterceptAlohaActivity19.ChangeItemSize(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.ChangeItemSize(employeeId, queueId, tableId, checkId, entryId);
        }

        void IInterceptAlohaActivity19.ClockIn(int employeeId, string empName, int jobcodeId, string jobName)
        {
            _service.ClockIn(employeeId, empName, jobcodeId, jobName);
        }

        void IInterceptAlohaActivity19.ClockOut(int employeeId, string empName)
        {
            _service.ClockOut(employeeId, empName);
        }

        void IInterceptAlohaActivity19.CloseCheck(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.CloseCheck(employeeId, queueId, tableId, checkId);
        }

        void IInterceptAlohaActivity19.CloseTable(int employeeId, int queueId, int tableId)
        {
            _service.CloseTable(employeeId, queueId, tableId);
        }

        void IInterceptAlohaActivity19.CombineOrder(int employeeId, int srcQueueId, int srcTableId, int srcCheckId, int dstQueueId, int dstTableId, int dstCheckId)
        {
            _service.CombineOrder(employeeId, srcQueueId, srcTableId, srcCheckId, dstQueueId, dstTableId, dstCheckId);
        }

        void IInterceptAlohaActivity19.CurrentCheckChanged(int termId, int tableId, int checkId)
        {
            _service.CurrentCheckChanged(termId, tableId, checkId);
        }

        void IInterceptAlohaActivity19.Custom(string name)
        {
            _service.Custom(name);
        }

        void IInterceptAlohaActivity19.DeassignCashDrawer(int employeeId, int drawerId, int isPublic)
        {
            _service.DeassignCashDrawer(employeeId, drawerId, isPublic);
        }

        void IInterceptAlohaActivity19.DeleteComp(int managerId, int employeeId, int queueId, int tableId, int checkId, int compTypeId, int compId)
        {
            _service.DeleteComp(managerId, employeeId, queueId, tableId, checkId, compTypeId, compId);
        }

        void IInterceptAlohaActivity19.DeleteItems(int managerId, int employeeId, int queueId, int tableId, int checkId, int reasonId)
        {
            _service.DeleteItems(managerId, employeeId, queueId, tableId, checkId, reasonId);
        }

        void IInterceptAlohaActivity19.DeleteLoyaltyMember(int checkId, string loyaltyCardNumber)
        {
            _service.DeleteLoyaltyMember(checkId, loyaltyCardNumber);
        }

        void IInterceptAlohaActivity19.DeletePayment(int managerId, int employeeId, int queueId, int tableId, int checkId, int tenderId, int paymentId)
        {
            _service.DeletePayment(managerId, employeeId, queueId, tableId, checkId, tenderId, paymentId);
        }

        void IInterceptAlohaActivity19.DeletePromo(int managerId, int employeeId, int queueId, int tableId, int checkId, int promotionId, int promoId)
        {
            _service.DeletePromo(managerId, employeeId, queueId, tableId, checkId, promotionId, promoId);
        }


        void IInterceptAlohaActivity19.EndOfDay(int isMaster)
        {
            _service.EndOfDay(isMaster);
        }

        void IInterceptAlohaActivity19.EnrollEmployee(int employeeId, int numTries)
        {
            _service.EnrollEmployee(employeeId, numTries);
        }

        void IInterceptAlohaActivity19.EnterIberScreen(int termId, int screenId)
        {
            _service.EnterIberScreen(termId, screenId);
        }

        void IInterceptAlohaActivity19.EventNotification(int employeeId, int tableId, ALOHA_ACTIVITY_EVENT_NOTIFICATION_TYPES eventNotification)
        {
            _service.EventNotification(employeeId, tableId, eventNotification);
        }

        void IInterceptAlohaActivity19.ExitIberScreen(int termId, int screenId)
        {
            _service.ExitIberScreen(termId, screenId);
        }

        void IInterceptAlohaActivity19.FileServer(string serverName)
        {
            _service.FileServer(serverName);
        }

        void IInterceptAlohaActivity19.FileServerDown()
        {
            _service.FileServerDown();
        }

        void IInterceptAlohaActivity19.FinalBump(int tableId)
        {
            _service.FinalBump(tableId);
        }


        void IInterceptAlohaActivity19.HoldItems(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.HoldItems(employeeId, queueId, tableId, checkId);
        }

        void IInterceptAlohaActivity19.IAmMaster()
        {
            _service.AmMaster();
        }

        void IInterceptAlohaActivity19.InitializationComplete()
        {
            _service.InitializationComplete();
        }

        void IInterceptAlohaActivity19.KitchenOrderStatus(string orders)
        {
            _service.KitchenOrderStatus(orders);
        }

        void IInterceptAlohaActivity19.LockOrder(int tableId)
        {
            _service.LockOrder(tableId);
        }

        void IInterceptAlohaActivity19.LogIn(int employeeId, string name)
        {
            _service.LogIn(employeeId, name);
        }

        void IInterceptAlohaActivity19.LogMergedByMaster(int masterTermId, int mergedTermId, string fileServerName)
        {
            _service.LogMergedByMaster(masterTermId, mergedTermId, fileServerName);
        }

        void IInterceptAlohaActivity19.LogOut(int employeeId, string name)
        {
            _service.LogOut(employeeId, name);
        }

        void IInterceptAlohaActivity19.MasterDown()
        {
            _service.MasterDown();
        }

        void IInterceptAlohaActivity19.MasterSyncedMyLog(int localTermId, int masterTermId, string fileServerName)
        {
            _service.MasterSyncedMyLog(localTermId, masterTermId, fileServerName);
        }

        void IInterceptAlohaActivity19.ModifyItem(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.ModifyItem(employeeId, queueId, tableId, checkId, entryId);
        }

        void IInterceptAlohaActivity19.NameOrder(int employeeId, int queueId, int tableId, string name, int checkId)
        {
            _service.NameOrder(employeeId, queueId, tableId, name, checkId);
        }

        void IInterceptAlohaActivity19.NameOrder(int employeeId, int queueId, int tableId, string name)
        {
            _service.NameOrder(employeeId, queueId, tableId, name);
        }

        void IInterceptAlohaActivity19.OnClockTick()
        {
            _service.OnClockTick();
        }

        void IInterceptAlohaActivity19.OpenCheck(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.OpenCheck(employeeId, queueId, tableId, checkId);
        }

        void IInterceptAlohaActivity19.OpenItem(int employeeId, int entryId, int itemId, string description, double price)
        {
            _service.OpenItem(employeeId, entryId, itemId, description, price);
        }

        void IInterceptAlohaActivity19.OpenTable(int employeeId, int queueId, int tableId, int tableDefId, string name)
        {
            _service.OpenTable(employeeId, queueId, tableId, tableDefId, name);
        }

        void IInterceptAlohaActivity19.OrderItems(int employeeId, int queueId, int tableId, int checkId, int modeId)
        {
            _service.OrderItems(employeeId, queueId, tableId, checkId, modeId);
        }

        void IInterceptAlohaActivity19.OrderScreen_TableCheckSeatChanged(int managerId, int employeeId, int queueId, int tableId, int checkId, int seatNum)
        {
            _service.OrderScreen_TableCheckSeatChanged(managerId, employeeId, queueId, tableId, checkId, seatNum);
        }

        void IInterceptAlohaActivity19.PostDeleteComp(int managerId, int employeeId, int queueId, int tableId, int checkId, int compTypeId, int compId)
        {
            _service.PostDeleteComp(managerId, employeeId, queueId, tableId, checkId, compTypeId, compId);
        }

        void IInterceptAlohaActivity19.PostDeleteItems(int managerId, int employeeId, int queueId, int tableId, int checkId, int reasonId)
        {
            _service.PostDeleteItems(managerId, employeeId, queueId, tableId, checkId, reasonId);
        }

        void IInterceptAlohaActivity19.PostDeletePromo(int managerId, int employeeId, int queueId, int tableId, int checkId, int promotionId, int promoId)
        {
            _service.PostDeletePromo(managerId, employeeId, queueId, tableId, checkId, promotionId, promoId);
        }

        void IInterceptAlohaActivity19.PostLockOrder(int termId)
        {
            _service.PostLockOrder(termId);
        }

        void IInterceptAlohaActivity19.PostUnlockOrder(int termId)
        {
            _service.PostUnlockOrder(termId);
        }

        void IInterceptAlohaActivity19.PreModifyItem(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.PreModifyItem(employeeId, queueId, tableId, checkId, entryId);
        }

        void IInterceptAlohaActivity19.ReassignCashDrawer(int employeeId, int drawerId)
        {
            _service.ReassignCashDrawer(employeeId, drawerId);
        }

        void IInterceptAlohaActivity19.RemoveDeferredModifier(int employeeId, int queueId, int tableId, int checkId, int parentEntryId, int modGroupId)
        {
            _service.RemoveDeferredModifier(employeeId, queueId, tableId, checkId, parentEntryId, modGroupId);
        }

        void IInterceptAlohaActivity19.RenameTab(int termId, int checkId, string tabName)
        {
            _service.RenameTab(termId, checkId, tabName);
        }

        void IInterceptAlohaActivity19.ReopenCheck(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.ReopenCheck(employeeId, queueId, tableId, checkId);
        }

        void IInterceptAlohaActivity19.ReqMasterToSyncMyLog(int localTermId, int masterTermId, string fileServerName)
        {
            _service.ReqMasterToSyncMyLog(localTermId, masterTermId, fileServerName);
        }

        void IInterceptAlohaActivity19.RerouteDisplayBoard(int employeeId, int queueId, int tableId, int checkId, int displayBoardId, int controllingTerminalId, int defaultOrderModeOverride, int currentOrderOnly)
        {
            _service.RerouteDisplayBoard(employeeId, queueId, tableId, checkId, displayBoardId, controllingTerminalId, defaultOrderModeOverride, currentOrderOnly);
        }

        void IInterceptAlohaActivity19.SaveTab(int employeeId, int tableId, string name)
        {
            _service.SaveTab(employeeId, tableId, name);
        }

        void IInterceptAlohaActivity19.SetMasterTerminal(int terminalId)
        {
            _service.SetMasterTerminal(terminalId);
        }

        void IInterceptAlohaActivity19.SetQuickComboLevel(int employeeId, int queueId, int tableId, int checkId, int promotionId, int promoId, int nLevel, int nContext)
        {
            _service.SetQuickComboLevel(employeeId, queueId, tableId, checkId, promotionId, promoId, nLevel, nContext);
        }

        void IInterceptAlohaActivity19.SettleInfoChanged(string settleInfo)
        {
            _service.SettleInfoChanged(settleInfo);
        }

        void IInterceptAlohaActivity19.Shutdown()
        {
            _service.Shutdown();
        }

        void IInterceptAlohaActivity19.SpecialMessage(int employeeId, int messageId, string message)
        {
            _service.SpecialMessage(employeeId, messageId, message);
        }

        void IInterceptAlohaActivity19.SplitCheck(int checkId, int tableId, int queueId, int employeeNumber, int numberOfSplits, int splitType)
        {
            _service.SplitCheck(checkId, tableId, queueId, employeeNumber, numberOfSplits, splitType);
        }

        void IInterceptAlohaActivity19.SpoolMode(int termId, int spoolMode)
        {
            _service.SpoolMode(termId, spoolMode);
        }

        void IInterceptAlohaActivity19.StartAddItem(int employeeId, int queueId, int tableId, int checkId, int entryId, int parentEntryId, int modCodeId, int itemId, string itemName, double itemPrice)
        {
            _service.StartAddItem(employeeId, queueId, tableId, checkId, entryId, parentEntryId, modCodeId, itemId, itemName, itemPrice);
        }

        void IInterceptAlohaActivity19.Startup(int hMainWnd)
        {
            _service.Startup(hMainWnd);
        }

        void IInterceptAlohaActivity19.TableToShowOnDispBChanged(int nTermId, int tableId)
        {
            _service.TableToShowOnDispBChanged(nTermId, tableId);
        }

        void IInterceptAlohaActivity19.TransferTable(int fromEmployeeId, int toEmployeeId, int tableId, string newName, int isGetCheck)
        {
            _service.TransferTable(fromEmployeeId, toEmployeeId, tableId, newName, isGetCheck);
        }

        void IInterceptAlohaActivity19.UnlockOrder(int tableId)
        {
            _service.UnlockOrder(tableId);
        }

        void IInterceptAlohaActivity19.UpdateDisplayBoard(int displayBoardId, int terminalId, int checkId)
        {
            _service.UpdateDisplayBoard(displayBoardId, terminalId, checkId);
        }

        void IInterceptAlohaActivity19.UpdateItems(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.UpdateItems(employeeId, queueId, tableId, checkId);
        }

    }
}
