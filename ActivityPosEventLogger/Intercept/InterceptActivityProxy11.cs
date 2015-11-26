using LasaActivity;

namespace ActivityPosEventLogger.Intercept
{
    public partial class InterceptActivityProxy
    {
        void IInterceptAlohaActivity11.AcceptTable(int employeeId, int fromTableId, int toTableId)
        {
            _service.AcceptTable(employeeId, fromTableId, toTableId);
        }

        void IInterceptAlohaActivity11.AddItem(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.AddItem(employeeId, queueId, tableId, checkId, entryId);
        }

        void IInterceptAlohaActivity11.AddTab(int employeeId, int fromTableId, int toTableId)
        {
            _service.AddTab(employeeId, fromTableId, toTableId);
        }

        void IInterceptAlohaActivity11.AdjustPayment(int managerId, int employeeId, int queueId, int tableId, int checkId, int tenderId, int paymentId)
        {
            _service.AdjustPayment(managerId, employeeId, queueId, tableId, checkId, tenderId, paymentId);
        }

        void IInterceptAlohaActivity11.AdvanceOrder(int employeeId, int queueId, int tableId)
        {
            _service.AdvanceOrder(employeeId, queueId, tableId);
        }

        void IInterceptAlohaActivity11.ApplyComp(int managerId, int employeeId, int queueId, int tableId, int checkId, int compTypeId, int compId)
        {
            _service.ApplyComp(managerId, employeeId, queueId, tableId, checkId, compTypeId, compId);
        }

        void IInterceptAlohaActivity11.ApplyPayment(int managerId, int employeeId, int queueId, int tableId, int checkId, int tenderId, int paymentId)
        {
            _service.ApplyPayment(managerId, employeeId, queueId, tableId, checkId, tenderId, paymentId);
        }

        void IInterceptAlohaActivity11.ApplyPromo(int managerId, int employeeId, int queueId, int tableId, int checkId, int promotionId, int promoId)
        {
            _service.ApplyPromo(managerId, employeeId, queueId, tableId, checkId, promotionId, promoId);
        }

        void IInterceptAlohaActivity11.AssignCashDrawer(int employeeId, int drawerId, int isPublic)
        {
            _service.AssignCashDrawer(employeeId, drawerId, isPublic);
        }

        void IInterceptAlohaActivity11.AuthorizePayment(int tableId, int checkId, int paymentId, int transactionType, int transactionResult)
        {
            _service.AuthorizePayment(tableId, checkId, paymentId, transactionType, transactionResult);
        }


        void IInterceptAlohaActivity11.Bump(int tableId)
        {
            _service.Bump(tableId);
        }

        void IInterceptAlohaActivity11.CancelAddItem(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.CancelAddItem(employeeId, queueId, tableId, checkId, entryId);
        }


        void IInterceptAlohaActivity11.CarryoverId(int type, int oldId, int newId)
        {
            _service.CarryoverId(type, oldId, newId);
        }

        void IInterceptAlohaActivity11.ChangeItemSize(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.ChangeItemSize(employeeId, queueId, tableId, checkId, entryId);
        }

        void IInterceptAlohaActivity11.ClockIn(int employeeId, string empName, int jobcodeId, string jobName)
        {
            _service.ClockIn(employeeId, empName, jobcodeId, jobName);
        }

        void IInterceptAlohaActivity11.ClockOut(int employeeId, string empName)
        {
            _service.ClockOut(employeeId, empName);
        }

        void IInterceptAlohaActivity11.CloseCheck(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.CloseCheck(employeeId, queueId, tableId, checkId);
        }

        void IInterceptAlohaActivity11.CloseTable(int employeeId, int queueId, int tableId)
        {
            _service.CloseTable(employeeId, queueId, tableId);
        }

        void IInterceptAlohaActivity11.CombineOrder(int employeeId, int srcQueueId, int srcTableId, int srcCheckId, int dstQueueId, int dstTableId, int dstCheckId)
        {
            _service.CombineOrder(employeeId, srcQueueId, srcTableId, srcCheckId, dstQueueId, dstTableId, dstCheckId);
        }

        void IInterceptAlohaActivity11.CurrentCheckChanged(int termId, int tableId, int checkId)
        {
            _service.CurrentCheckChanged(termId, tableId, checkId);
        }

        void IInterceptAlohaActivity11.Custom(string name)
        {
            _service.Custom(name);
        }

        void IInterceptAlohaActivity11.DeassignCashDrawer(int employeeId, int drawerId, int isPublic)
        {
            _service.DeassignCashDrawer(employeeId, drawerId, isPublic);
        }

        void IInterceptAlohaActivity11.DeleteComp(int managerId, int employeeId, int queueId, int tableId, int checkId, int compTypeId, int compId)
        {
            _service.DeleteComp(managerId, employeeId, queueId, tableId, checkId, compTypeId, compId);
        }

        void IInterceptAlohaActivity11.DeleteItems(int managerId, int employeeId, int queueId, int tableId, int checkId, int reasonId)
        {
            _service.DeleteItems(managerId, employeeId, queueId, tableId, checkId, reasonId);
        }

        void IInterceptAlohaActivity11.DeletePayment(int managerId, int employeeId, int queueId, int tableId, int checkId, int tenderId, int paymentId)
        {
            _service.DeletePayment(managerId, employeeId, queueId, tableId, checkId, tenderId, paymentId);
        }

        void IInterceptAlohaActivity11.DeletePromo(int managerId, int employeeId, int queueId, int tableId, int checkId, int promotionId, int promoId)
        {
            _service.DeletePromo(managerId, employeeId, queueId, tableId, checkId, promotionId, promoId);
        }


        void IInterceptAlohaActivity11.EndOfDay(int isMaster)
        {
            _service.EndOfDay(isMaster);
        }

        void IInterceptAlohaActivity11.EnrollEmployee(int employeeId, int numTries)
        {
            _service.EnrollEmployee(employeeId, numTries);
        }

        void IInterceptAlohaActivity11.EnterIberScreen(int termId, int screenId)
        {
            _service.EnterIberScreen(termId, screenId);
        }

        void IInterceptAlohaActivity11.EventNotification(int employeeId, int tableId, ALOHA_ACTIVITY_EVENT_NOTIFICATION_TYPES eventNotification)
        {
            _service.EventNotification(employeeId, tableId, eventNotification);
        }

        void IInterceptAlohaActivity11.ExitIberScreen(int termId, int screenId)
        {
            _service.ExitIberScreen(termId, screenId);
        }

        void IInterceptAlohaActivity11.FileServer(string serverName)
        {
            _service.FileServer(serverName);
        }

        void IInterceptAlohaActivity11.FileServerDown()
        {
            _service.FileServerDown();
        }

        void IInterceptAlohaActivity11.FinalBump(int tableId)
        {
            _service.FinalBump(tableId);
        }


        void IInterceptAlohaActivity11.HoldItems(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.HoldItems(employeeId, queueId, tableId, checkId);
        }

        void IInterceptAlohaActivity11.IAmMaster()
        {
            _service.AmMaster();
        }

        void IInterceptAlohaActivity11.InitializationComplete()
        {
            _service.InitializationComplete();
        }

        void IInterceptAlohaActivity11.LockOrder(int tableId)
        {
            _service.LockOrder(tableId);
        }

        void IInterceptAlohaActivity11.LogIn(int employeeId, string name)
        {
            _service.LogIn(employeeId, name);
        }

        void IInterceptAlohaActivity11.LogOut(int employeeId, string name)
        {
            _service.LogOut(employeeId, name);
        }

        void IInterceptAlohaActivity11.MasterDown()
        {
            _service.MasterDown();
        }

        void IInterceptAlohaActivity11.ModifyItem(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.ModifyItem(employeeId, queueId, tableId, checkId, entryId);
        }

        void IInterceptAlohaActivity11.NameOrder(int employeeId, int queueId, int tableId, string name, int checkId)
        {
            _service.NameOrder(employeeId, queueId, tableId, name, checkId);
        }

        void IInterceptAlohaActivity11.NameOrder(int employeeId, int queueId, int tableId, string name)
        {
            _service.NameOrder(employeeId, queueId, tableId, name);
        }

        void IInterceptAlohaActivity11.OnClockTick()
        {
            _service.OnClockTick();
        }

        void IInterceptAlohaActivity11.OpenCheck(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.OpenCheck(employeeId, queueId, tableId, checkId);
        }

        void IInterceptAlohaActivity11.OpenItem(int employeeId, int entryId, int itemId, string description, double price)
        {
            _service.OpenItem(employeeId, entryId, itemId, description, price);
        }

        void IInterceptAlohaActivity11.OpenTable(int employeeId, int queueId, int tableId, int tableDefId, string name)
        {
            _service.OpenTable(employeeId, queueId, tableId, tableDefId, name);
        }

        void IInterceptAlohaActivity11.OrderItems(int employeeId, int queueId, int tableId, int checkId, int modeId)
        {
            _service.OrderItems(employeeId, queueId, tableId, checkId, modeId);
        }

        void IInterceptAlohaActivity11.OrderScreen_TableCheckSeatChanged(int managerId, int employeeId, int queueId, int tableId, int checkId, int seatNum)
        {
            _service.OrderScreen_TableCheckSeatChanged(managerId, employeeId, queueId, tableId, checkId, seatNum);
        }

        void IInterceptAlohaActivity11.PostDeleteComp(int managerId, int employeeId, int queueId, int tableId, int checkId, int compTypeId, int compId)
        {
            _service.PostDeleteComp(managerId, employeeId, queueId, tableId, checkId, compTypeId, compId);
        }

        void IInterceptAlohaActivity11.PostDeleteItems(int managerId, int employeeId, int queueId, int tableId, int checkId, int reasonId)
        {
            _service.PostDeleteItems(managerId, employeeId, queueId, tableId, checkId, reasonId);
        }

        void IInterceptAlohaActivity11.PostDeletePromo(int managerId, int employeeId, int queueId, int tableId, int checkId, int promotionId, int promoId)
        {
            _service.PostDeletePromo(managerId, employeeId, queueId, tableId, checkId, promotionId, promoId);
        }

        void IInterceptAlohaActivity11.PreModifyItem(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.PreModifyItem(employeeId, queueId, tableId, checkId, entryId);
        }

        void IInterceptAlohaActivity11.ReassignCashDrawer(int employeeId, int drawerId)
        {
            _service.ReassignCashDrawer(employeeId, drawerId);
        }

        void IInterceptAlohaActivity11.ReopenCheck(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.ReopenCheck(employeeId, queueId, tableId, checkId);
        }

        void IInterceptAlohaActivity11.RerouteDisplayBoard(int employeeId, int queueId, int tableId, int checkId, int displayBoardId, int controllingTerminalId, int defaultOrderModeOverride, int currentOrderOnly)
        {
            _service.RerouteDisplayBoard(employeeId, queueId, tableId, checkId, displayBoardId, controllingTerminalId, defaultOrderModeOverride, currentOrderOnly);
        }

        void IInterceptAlohaActivity11.SaveTab(int employeeId, int tableId, string name)
        {
            _service.SaveTab(employeeId, tableId, name);
        }

        void IInterceptAlohaActivity11.SetMasterTerminal(int terminalId)
        {
            _service.SetMasterTerminal(terminalId);
        }

        void IInterceptAlohaActivity11.SetQuickComboLevel(int employeeId, int queueId, int tableId, int checkId, int promotionId, int promoId, int nLevel, int nContext)
        {
            _service.SetQuickComboLevel(employeeId, queueId, tableId, checkId, promotionId, promoId, nLevel, nContext);
        }

        void IInterceptAlohaActivity11.SettleInfoChanged(string settleInfo)
        {
            _service.SettleInfoChanged(settleInfo);
        }

        void IInterceptAlohaActivity11.Shutdown()
        {
            _service.Shutdown();
        }

        void IInterceptAlohaActivity11.SpecialMessage(int employeeId, int messageId, string message)
        {
            _service.SpecialMessage(employeeId, messageId, message);
        }

        void IInterceptAlohaActivity11.SplitCheck(int checkId, int tableId, int queueId, int employeeNumber, int numberOfSplits, int splitType)
        {
            _service.SplitCheck(checkId, tableId, queueId, employeeNumber, numberOfSplits, splitType);
        }

        void IInterceptAlohaActivity11.StartAddItem(int employeeId, int queueId, int tableId, int checkId, int entryId, int parentEntryId, int modCodeId, int itemId, string itemName, double itemPrice)
        {
            _service.StartAddItem(employeeId, queueId, tableId, checkId, entryId, parentEntryId, modCodeId, itemId, itemName, itemPrice);
        }

        void IInterceptAlohaActivity11.Startup(int hMainWnd)
        {
            _service.Startup(hMainWnd);
        }

        void IInterceptAlohaActivity11.TableToShowOnDispBChanged(int nTermId, int tableId)
        {
            _service.TableToShowOnDispBChanged(nTermId, tableId);
        }

        void IInterceptAlohaActivity11.TransferTable(int fromEmployeeId, int toEmployeeId, int tableId, string newName, int isGetCheck)
        {
            _service.TransferTable(fromEmployeeId, toEmployeeId, tableId, newName, isGetCheck);
        }

        void IInterceptAlohaActivity11.UnlockOrder(int tableId)
        {
            _service.UnlockOrder(tableId);
        }

        void IInterceptAlohaActivity11.UpdateItems(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.UpdateItems(employeeId, queueId, tableId, checkId);
        }
    }
}
