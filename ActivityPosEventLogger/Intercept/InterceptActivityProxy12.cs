using LasaActivity;

namespace ActivityPosEventLogger.Intercept
{
    public partial class InterceptActivityProxy
    {
        void IInterceptAlohaActivity12.AcceptTable(int employeeId, int fromTableId, int toTableId)
        {
            _service.AcceptTable(employeeId, fromTableId, toTableId);
        }

        void IInterceptAlohaActivity12.AddItem(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.AddItem(employeeId, queueId, tableId, checkId, entryId);
        }

        void IInterceptAlohaActivity12.AddTab(int employeeId, int fromTableId, int toTableId)
        {
            _service.AddTab(employeeId, fromTableId, toTableId);
        }

        void IInterceptAlohaActivity12.AdjustPayment(int managerId, int employeeId, int queueId, int tableId, int checkId, int tenderId, int paymentId)
        {
            _service.AdjustPayment(managerId, employeeId, queueId, tableId, checkId, tenderId, paymentId);
        }

        void IInterceptAlohaActivity12.AdvanceOrder(int employeeId, int queueId, int tableId)
        {
            _service.AdvanceOrder(employeeId, queueId, tableId);
        }

        void IInterceptAlohaActivity12.ApplyComp(int managerId, int employeeId, int queueId, int tableId, int checkId, int compTypeId, int compId)
        {
            _service.ApplyComp(managerId, employeeId, queueId, tableId, checkId, compTypeId, compId);
        }

        void IInterceptAlohaActivity12.ApplyPayment(int managerId, int employeeId, int queueId, int tableId, int checkId, int tenderId, int paymentId)
        {
            _service.ApplyPayment(managerId, employeeId, queueId, tableId, checkId, tenderId, paymentId);
        }

        void IInterceptAlohaActivity12.ApplyPromo(int managerId, int employeeId, int queueId, int tableId, int checkId, int promotionId, int promoId)
        {
            _service.ApplyPromo(managerId, employeeId, queueId, tableId, checkId, promotionId, promoId);
        }

        void IInterceptAlohaActivity12.AssignCashDrawer(int employeeId, int drawerId, int isPublic)
        {
            _service.AssignCashDrawer(employeeId, drawerId, isPublic);
        }

        void IInterceptAlohaActivity12.AuthorizePayment(int tableId, int checkId, int paymentId, int transactionType, int transactionResult)
        {
            _service.AuthorizePayment(tableId, checkId, paymentId, transactionType, transactionResult);
        }


        void IInterceptAlohaActivity12.Bump(int tableId)
        {
            _service.Bump(tableId);
        }

        void IInterceptAlohaActivity12.CancelAddItem(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.CancelAddItem(employeeId, queueId, tableId, checkId, entryId);
        }


        void IInterceptAlohaActivity12.CarryoverId(int type, int oldId, int newId)
        {
            _service.CarryoverId(type, oldId, newId);
        }

        void IInterceptAlohaActivity12.ChangeItemSize(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.ChangeItemSize(employeeId, queueId, tableId, checkId, entryId);
        }

        void IInterceptAlohaActivity12.ClockIn(int employeeId, string empName, int jobcodeId, string jobName)
        {
            _service.ClockIn(employeeId, empName, jobcodeId, jobName);
        }

        void IInterceptAlohaActivity12.ClockOut(int employeeId, string empName)
        {
            _service.ClockOut(employeeId, empName);
        }

        void IInterceptAlohaActivity12.CloseCheck(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.CloseCheck(employeeId, queueId, tableId, checkId);
        }

        void IInterceptAlohaActivity12.CloseTable(int employeeId, int queueId, int tableId)
        {
            _service.CloseTable(employeeId, queueId, tableId);
        }

        void IInterceptAlohaActivity12.CombineOrder(int employeeId, int srcQueueId, int srcTableId, int srcCheckId, int dstQueueId, int dstTableId, int dstCheckId)
        {
            _service.CombineOrder(employeeId, srcQueueId, srcTableId, srcCheckId, dstQueueId, dstTableId, dstCheckId);
        }

        void IInterceptAlohaActivity12.CurrentCheckChanged(int termId, int tableId, int checkId)
        {
            _service.CurrentCheckChanged(termId, tableId, checkId);
        }

        void IInterceptAlohaActivity12.Custom(string name)
        {
            _service.Custom(name);
        }

        void IInterceptAlohaActivity12.DeassignCashDrawer(int employeeId, int drawerId, int isPublic)
        {
            _service.DeassignCashDrawer(employeeId, drawerId, isPublic);
        }

        void IInterceptAlohaActivity12.DeleteComp(int managerId, int employeeId, int queueId, int tableId, int checkId, int compTypeId, int compId)
        {
            _service.DeleteComp(managerId, employeeId, queueId, tableId, checkId, compTypeId, compId);
        }

        void IInterceptAlohaActivity12.DeleteItems(int managerId, int employeeId, int queueId, int tableId, int checkId, int reasonId)
        {
            _service.DeleteItems(managerId, employeeId, queueId, tableId, checkId, reasonId);
        }

        void IInterceptAlohaActivity12.DeletePayment(int managerId, int employeeId, int queueId, int tableId, int checkId, int tenderId, int paymentId)
        {
            _service.DeletePayment(managerId, employeeId, queueId, tableId, checkId, tenderId, paymentId);
        }

        void IInterceptAlohaActivity12.DeletePromo(int managerId, int employeeId, int queueId, int tableId, int checkId, int promotionId, int promoId)
        {
            _service.DeletePromo(managerId, employeeId, queueId, tableId, checkId, promotionId, promoId);
        }


        void IInterceptAlohaActivity12.EndOfDay(int isMaster)
        {
            _service.EndOfDay(isMaster);
        }

        void IInterceptAlohaActivity12.EnrollEmployee(int employeeId, int numTries)
        {
            _service.EnrollEmployee(employeeId, numTries);
        }

        void IInterceptAlohaActivity12.EnterIberScreen(int termId, int screenId)
        {
            _service.EnterIberScreen(termId, screenId);
        }

        void IInterceptAlohaActivity12.EventNotification(int employeeId, int tableId, ALOHA_ACTIVITY_EVENT_NOTIFICATION_TYPES eventNotification)
        {
            _service.EventNotification(employeeId, tableId, eventNotification);
        }

        void IInterceptAlohaActivity12.ExitIberScreen(int termId, int screenId)
        {
            _service.ExitIberScreen(termId, screenId);
        }

        void IInterceptAlohaActivity12.FileServer(string serverName)
        {
            _service.FileServer(serverName);
        }

        void IInterceptAlohaActivity12.FileServerDown()
        {
            _service.FileServerDown();
        }

        void IInterceptAlohaActivity12.FinalBump(int tableId)
        {
            _service.FinalBump(tableId);
        }


        void IInterceptAlohaActivity12.HoldItems(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.HoldItems(employeeId, queueId, tableId, checkId);
        }

        void IInterceptAlohaActivity12.IAmMaster()
        {
            _service.AmMaster();
        }

        void IInterceptAlohaActivity12.InitializationComplete()
        {
            _service.InitializationComplete();
        }

        void IInterceptAlohaActivity12.KitchenOrderStatus(string orders)
        {
            _service.KitchenOrderStatus(orders);
        }

        void IInterceptAlohaActivity12.LockOrder(int tableId)
        {
            _service.LockOrder(tableId);
        }

        void IInterceptAlohaActivity12.LogIn(int employeeId, string name)
        {
            _service.LogIn(employeeId, name);
        }

        void IInterceptAlohaActivity12.LogOut(int employeeId, string name)
        {
            _service.LogOut(employeeId, name);
        }

        void IInterceptAlohaActivity12.MasterDown()
        {
            _service.MasterDown();
        }

        void IInterceptAlohaActivity12.ModifyItem(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.ModifyItem(employeeId, queueId, tableId, checkId, entryId);
        }

        void IInterceptAlohaActivity12.NameOrder(int employeeId, int queueId, int tableId, string name, int checkId)
        {
            _service.NameOrder(employeeId, queueId, tableId, name, checkId);
        }

        void IInterceptAlohaActivity12.NameOrder(int employeeId, int queueId, int tableId, string name)
        {
            _service.NameOrder(employeeId, queueId, tableId, name);
        }

        void IInterceptAlohaActivity12.OnClockTick()
        {
            _service.OnClockTick();
        }

        void IInterceptAlohaActivity12.OpenCheck(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.OpenCheck(employeeId, queueId, tableId, checkId);
        }

        void IInterceptAlohaActivity12.OpenItem(int employeeId, int entryId, int itemId, string description, double price)
        {
            _service.OpenItem(employeeId, entryId, itemId, description, price);
        }

        void IInterceptAlohaActivity12.OpenTable(int employeeId, int queueId, int tableId, int tableDefId, string name)
        {
            _service.OpenTable(employeeId, queueId, tableId, tableDefId, name);
        }

        void IInterceptAlohaActivity12.OrderItems(int employeeId, int queueId, int tableId, int checkId, int modeId)
        {
            _service.OrderItems(employeeId, queueId, tableId, checkId, modeId);
        }

        void IInterceptAlohaActivity12.OrderScreen_TableCheckSeatChanged(int managerId, int employeeId, int queueId, int tableId, int checkId, int seatNum)
        {
            _service.OrderScreen_TableCheckSeatChanged(managerId, employeeId, queueId, tableId, checkId, seatNum);
        }

        void IInterceptAlohaActivity12.PostDeleteComp(int managerId, int employeeId, int queueId, int tableId, int checkId, int compTypeId, int compId)
        {
            _service.PostDeleteComp(managerId, employeeId, queueId, tableId, checkId, compTypeId, compId);
        }

        void IInterceptAlohaActivity12.PostDeleteItems(int managerId, int employeeId, int queueId, int tableId, int checkId, int reasonId)
        {
            _service.PostDeleteItems(managerId, employeeId, queueId, tableId, checkId, reasonId);
        }

        void IInterceptAlohaActivity12.PostDeletePromo(int managerId, int employeeId, int queueId, int tableId, int checkId, int promotionId, int promoId)
        {
            _service.PostDeletePromo(managerId, employeeId, queueId, tableId, checkId, promotionId, promoId);
        }

        void IInterceptAlohaActivity12.PreModifyItem(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.PreModifyItem(employeeId, queueId, tableId, checkId, entryId);
        }

        void IInterceptAlohaActivity12.ReassignCashDrawer(int employeeId, int drawerId)
        {
            _service.ReassignCashDrawer(employeeId, drawerId);
        }

        void IInterceptAlohaActivity12.ReopenCheck(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.ReopenCheck(employeeId, queueId, tableId, checkId);
        }

        void IInterceptAlohaActivity12.RerouteDisplayBoard(int employeeId, int queueId, int tableId, int checkId, int displayBoardId, int controllingTerminalId, int defaultOrderModeOverride, int currentOrderOnly)
        {
            _service.RerouteDisplayBoard(employeeId, queueId, tableId, checkId, displayBoardId, controllingTerminalId, defaultOrderModeOverride, currentOrderOnly);
        }

        void IInterceptAlohaActivity12.SaveTab(int employeeId, int tableId, string name)
        {
            _service.SaveTab(employeeId, tableId, name);
        }

        void IInterceptAlohaActivity12.SetMasterTerminal(int terminalId)
        {
            _service.SetMasterTerminal(terminalId);
        }

        void IInterceptAlohaActivity12.SetQuickComboLevel(int employeeId, int queueId, int tableId, int checkId, int promotionId, int promoId, int nLevel, int nContext)
        {
            _service.SetQuickComboLevel(employeeId, queueId, tableId, checkId, promotionId, promoId, nLevel, nContext);
        }

        void IInterceptAlohaActivity12.SettleInfoChanged(string settleInfo)
        {
            _service.SettleInfoChanged(settleInfo);
        }

        void IInterceptAlohaActivity12.Shutdown()
        {
            _service.Shutdown();
        }

        void IInterceptAlohaActivity12.SpecialMessage(int employeeId, int messageId, string message)
        {
            _service.SpecialMessage(employeeId, messageId, message);
        }

        void IInterceptAlohaActivity12.SplitCheck(int checkId, int tableId, int queueId, int employeeNumber, int numberOfSplits, int splitType)
        {
            _service.SplitCheck(checkId, tableId, queueId, employeeNumber, numberOfSplits, splitType);
        }

        void IInterceptAlohaActivity12.StartAddItem(int employeeId, int queueId, int tableId, int checkId, int entryId, int parentEntryId, int modCodeId, int itemId, string itemName, double itemPrice)
        {
            _service.StartAddItem(employeeId, queueId, tableId, checkId, entryId, parentEntryId, modCodeId, itemId, itemName, itemPrice);
        }

        void IInterceptAlohaActivity12.Startup(int hMainWnd)
        {
            _service.Startup(hMainWnd);
        }

        void IInterceptAlohaActivity12.TableToShowOnDispBChanged(int nTermId, int tableId)
        {
            _service.TableToShowOnDispBChanged(nTermId, tableId);
        }

        void IInterceptAlohaActivity12.TransferTable(int fromEmployeeId, int toEmployeeId, int tableId, string newName, int isGetCheck)
        {
            _service.TransferTable(fromEmployeeId, toEmployeeId, tableId, newName, isGetCheck);
        }

        void IInterceptAlohaActivity12.UnlockOrder(int tableId)
        {
            _service.UnlockOrder(tableId);
        }

        void IInterceptAlohaActivity12.UpdateItems(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.UpdateItems(employeeId, queueId, tableId, checkId);
        }
    }
}
