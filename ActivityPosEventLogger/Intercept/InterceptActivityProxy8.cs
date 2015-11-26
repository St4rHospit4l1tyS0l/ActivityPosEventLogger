using LasaActivity;

namespace ActivityPosEventLogger.Intercept
{
    public partial class InterceptActivityProxy
    {
        void IInterceptAlohaActivity8.AcceptTable(int employeeId, int fromTableId, int toTableId)
        {
            _service.AcceptTable(employeeId, fromTableId, toTableId);
        }

        void IInterceptAlohaActivity8.AddItem(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.AddItem(employeeId, queueId, tableId, checkId, entryId);
        }

        void IInterceptAlohaActivity8.AddTab(int employeeId, int fromTableId, int toTableId)
        {
            _service.AddTab(employeeId, fromTableId, toTableId);
        }

        void IInterceptAlohaActivity8.AdjustPayment(int managerId, int employeeId, int queueId, int tableId, int checkId, int tenderId, int paymentId)
        {
            _service.AdjustPayment(managerId, employeeId, queueId, tableId, checkId, tenderId, paymentId);
        }

        void IInterceptAlohaActivity8.AdvanceOrder(int employeeId, int queueId, int tableId)
        {
            _service.AdvanceOrder(employeeId, queueId, tableId);
        }

        void IInterceptAlohaActivity8.ApplyComp(int managerId, int employeeId, int queueId, int tableId, int checkId, int compTypeId, int compId)
        {
            _service.ApplyComp(managerId, employeeId, queueId, tableId, checkId, compTypeId, compId);
        }

        void IInterceptAlohaActivity8.ApplyPayment(int managerId, int employeeId, int queueId, int tableId, int checkId, int tenderId, int paymentId)
        {
            _service.ApplyPayment(managerId, employeeId, queueId, tableId, checkId, tenderId, paymentId);
        }

        void IInterceptAlohaActivity8.ApplyPromo(int managerId, int employeeId, int queueId, int tableId, int checkId, int promotionId, int promoId)
        {
            _service.ApplyPromo(managerId, employeeId, queueId, tableId, checkId, promotionId, promoId);
        }

        void IInterceptAlohaActivity8.AuthorizePayment(int tableId, int checkId, int paymentId, int transactionType, int transactionResult)
        {
            _service.AuthorizePayment(tableId, checkId, paymentId, transactionType, transactionResult);
        }


        void IInterceptAlohaActivity8.Bump(int tableId)
        {
            _service.Bump(tableId);
        }

        void IInterceptAlohaActivity8.CancelAddItem(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.CancelAddItem(employeeId, queueId, tableId, checkId, entryId);
        }


        void IInterceptAlohaActivity8.CarryoverId(int type, int oldId, int newId)
        {
            _service.CarryoverId(type, oldId, newId);
        }

        void IInterceptAlohaActivity8.ChangeItemSize(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.ChangeItemSize(employeeId, queueId, tableId, checkId, entryId);
        }

        void IInterceptAlohaActivity8.ClockIn(int employeeId, string empName, int jobcodeId, string jobName)
        {
            _service.ClockIn(employeeId, empName, jobcodeId, jobName);
        }

        void IInterceptAlohaActivity8.ClockOut(int employeeId, string empName)
        {
            _service.ClockOut(employeeId, empName);
        }

        void IInterceptAlohaActivity8.CloseCheck(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.CloseCheck(employeeId, queueId, tableId, checkId);
        }

        void IInterceptAlohaActivity8.CloseTable(int employeeId, int queueId, int tableId)
        {
            _service.CloseTable(employeeId, queueId, tableId);
        }

        void IInterceptAlohaActivity8.CombineOrder(int employeeId, int srcQueueId, int srcTableId, int srcCheckId, int dstQueueId, int dstTableId, int dstCheckId)
        {
            _service.CombineOrder(employeeId, srcQueueId, srcTableId, srcCheckId, dstQueueId, dstTableId, dstCheckId);
        }

        void IInterceptAlohaActivity8.CurrentCheckChanged(int termId, int tableId, int checkId)
        {
            _service.CurrentCheckChanged(termId, tableId, checkId);
        }

        void IInterceptAlohaActivity8.Custom(string name)
        {
            _service.Custom(name);
        }

        void IInterceptAlohaActivity8.DeleteComp(int managerId, int employeeId, int queueId, int tableId, int checkId, int compTypeId, int compId)
        {
            _service.DeleteComp(managerId, employeeId, queueId, tableId, checkId, compTypeId, compId);
        }

        void IInterceptAlohaActivity8.DeleteItems(int managerId, int employeeId, int queueId, int tableId, int checkId, int reasonId)
        {
            _service.DeleteItems(managerId, employeeId, queueId, tableId, checkId, reasonId);
        }

        void IInterceptAlohaActivity8.DeletePayment(int managerId, int employeeId, int queueId, int tableId, int checkId, int tenderId, int paymentId)
        {
            _service.DeletePayment(managerId, employeeId, queueId, tableId, checkId, tenderId, paymentId);
        }

        void IInterceptAlohaActivity8.DeletePromo(int managerId, int employeeId, int queueId, int tableId, int checkId, int promotionId, int promoId)
        {
            _service.DeletePromo(managerId, employeeId, queueId, tableId, checkId, promotionId, promoId);
        }


        void IInterceptAlohaActivity8.EndOfDay(int isMaster)
        {
            _service.EndOfDay(isMaster);
        }

        void IInterceptAlohaActivity8.EnrollEmployee(int employeeId, int numTries)
        {
            _service.EnrollEmployee(employeeId, numTries);
        }

        void IInterceptAlohaActivity8.EventNotification(int employeeId, int tableId, ALOHA_ACTIVITY_EVENT_NOTIFICATION_TYPES eventNotification)
        {
            _service.EventNotification(employeeId, tableId, eventNotification);
        }

        void IInterceptAlohaActivity8.FileServer(string serverName)
        {
            _service.FileServer(serverName);
        }

        void IInterceptAlohaActivity8.FileServerDown()
        {
            _service.FileServerDown();
        }

        void IInterceptAlohaActivity8.FinalBump(int tableId)
        {
            _service.FinalBump(tableId);
        }


        void IInterceptAlohaActivity8.HoldItems(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.HoldItems(employeeId, queueId, tableId, checkId);
        }

        void IInterceptAlohaActivity8.IAmMaster()
        {
            _service.AmMaster();
        }

        void IInterceptAlohaActivity8.InitializationComplete()
        {
            _service.InitializationComplete();
        }

        void IInterceptAlohaActivity8.LockOrder(int tableId)
        {
            _service.LockOrder(tableId);
        }

        void IInterceptAlohaActivity8.LogIn(int employeeId, string name)
        {
            _service.LogIn(employeeId, name);
        }

        void IInterceptAlohaActivity8.LogOut(int employeeId, string name)
        {
            _service.LogOut(employeeId, name);
        }

        void IInterceptAlohaActivity8.MasterDown()
        {
            _service.MasterDown();
        }

        void IInterceptAlohaActivity8.ModifyItem(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.ModifyItem(employeeId, queueId, tableId, checkId, entryId);
        }

        void IInterceptAlohaActivity8.NameOrder(int employeeId, int queueId, int tableId, string name)
        {
            _service.NameOrder(employeeId, queueId, tableId, name);
        }

        void IInterceptAlohaActivity8.OnClockTick()
        {
            _service.OnClockTick();
        }

        void IInterceptAlohaActivity8.OpenCheck(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.OpenCheck(employeeId, queueId, tableId, checkId);
        }

        void IInterceptAlohaActivity8.OpenItem(int employeeId, int entryId, int itemId, string description, double price)
        {
            _service.OpenItem(employeeId, entryId, itemId, description, price);
        }

        void IInterceptAlohaActivity8.OpenTable(int employeeId, int queueId, int tableId, int tableDefId, string name)
        {
            _service.OpenTable(employeeId, queueId, tableId, tableDefId, name);
        }

        void IInterceptAlohaActivity8.OrderItems(int employeeId, int queueId, int tableId, int checkId, int modeId)
        {
            _service.OrderItems(employeeId, queueId, tableId, checkId, modeId);
        }

        void IInterceptAlohaActivity8.OrderScreen_TableCheckSeatChanged(int managerId, int employeeId, int queueId, int tableId, int checkId, int seatNum)
        {
            _service.OrderScreen_TableCheckSeatChanged(managerId, employeeId, queueId, tableId, checkId, seatNum);
        }

        void IInterceptAlohaActivity8.PostDeleteComp(int managerId, int employeeId, int queueId, int tableId, int checkId, int compTypeId, int compId)
        {
            _service.PostDeleteComp(managerId, employeeId, queueId, tableId, checkId, compTypeId, compId);
        }

        void IInterceptAlohaActivity8.PostDeleteItems(int managerId, int employeeId, int queueId, int tableId, int checkId, int reasonId)
        {
            _service.PostDeleteItems(managerId, employeeId, queueId, tableId, checkId, reasonId);
        }

        void IInterceptAlohaActivity8.PostDeletePromo(int managerId, int employeeId, int queueId, int tableId, int checkId, int promotionId, int promoId)
        {
            _service.PostDeletePromo(managerId, employeeId, queueId, tableId, checkId, promotionId, promoId);
        }

        void IInterceptAlohaActivity8.PreModifyItem(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.PreModifyItem(employeeId, queueId, tableId, checkId, entryId);
        }

        void IInterceptAlohaActivity8.RerouteDisplayBoard(int employeeId, int queueId, int tableId, int checkId, int displayBoardId, int controllingTerminalId, int defaultOrderModeOverride, int currentOrderOnly)
        {
            _service.RerouteDisplayBoard(employeeId, queueId, tableId, checkId, displayBoardId, controllingTerminalId, defaultOrderModeOverride, currentOrderOnly);
        }

        void IInterceptAlohaActivity8.SaveTab(int employeeId, int tableId, string name)
        {
            _service.SaveTab(employeeId, tableId, name);
        }

        void IInterceptAlohaActivity8.SetMasterTerminal(int terminalId)
        {
            _service.SetMasterTerminal(terminalId);
        }

        void IInterceptAlohaActivity8.SetQuickComboLevel(int employeeId, int queueId, int tableId, int checkId, int promotionId, int promoId, int nLevel, int nContext)
        {
            _service.SetQuickComboLevel(employeeId, queueId, tableId, checkId, promotionId, promoId, nLevel, nContext);
        }

        void IInterceptAlohaActivity8.SettleInfoChanged(string settleInfo)
        {
            _service.SettleInfoChanged(settleInfo);
        }

        void IInterceptAlohaActivity8.Shutdown()
        {
            _service.Shutdown();
        }

        void IInterceptAlohaActivity8.SpecialMessage(int employeeId, int messageId, string message)
        {
            _service.SpecialMessage(employeeId, messageId, message);
        }

        void IInterceptAlohaActivity8.SplitCheck(int checkId, int tableId, int queueId, int employeeNumber, int numberOfSplits, int splitType)
        {
            _service.SplitCheck(checkId, tableId, queueId, employeeNumber, numberOfSplits, splitType);
        }

        void IInterceptAlohaActivity8.StartAddItem(int employeeId, int queueId, int tableId, int checkId, int entryId, int parentEntryId, int modCodeId, int itemId, string itemName, double itemPrice)
        {
            _service.StartAddItem(employeeId, queueId, tableId, checkId, entryId, parentEntryId, modCodeId, itemId, itemName, itemPrice);
        }

        void IInterceptAlohaActivity8.Startup(int hMainWnd)
        {
            _service.Startup(hMainWnd);
        }

        void IInterceptAlohaActivity8.TableToShowOnDispBChanged(int nTermId, int tableId)
        {
            _service.TableToShowOnDispBChanged(nTermId, tableId);
        }

        void IInterceptAlohaActivity8.TransferTable(int fromEmployeeId, int toEmployeeId, int tableId, string newName, int isGetCheck)
        {
            _service.TransferTable(fromEmployeeId, toEmployeeId, tableId, newName, isGetCheck);
        }

        void IInterceptAlohaActivity8.UnlockOrder(int tableId)
        {
            _service.UnlockOrder(tableId);
        }

        void IInterceptAlohaActivity8.UpdateItems(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.UpdateItems(employeeId, queueId, tableId, checkId);
        }

    }
}
