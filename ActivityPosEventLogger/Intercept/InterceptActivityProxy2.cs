using LasaActivity;

namespace ActivityPosEventLogger.Intercept
{
    public partial class InterceptActivityProxy
    {
        void IInterceptAlohaActivity2.AcceptTable(int employeeId, int fromTableId, int toTableId)
        {
            _service.AcceptTable(employeeId, fromTableId, toTableId);
        }

        void IInterceptAlohaActivity2.AddItem(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.AddItem(employeeId, queueId, tableId, checkId, entryId);
        }

        void IInterceptAlohaActivity2.AddTab(int employeeId, int fromTableId, int toTableId)
        {
            _service.AddTab(employeeId, fromTableId, toTableId);
        }

        void IInterceptAlohaActivity2.AdjustPayment(int managerId, int employeeId, int queueId, int tableId, int checkId, int tenderId, int paymentId)
        {
            _service.AdjustPayment(managerId, employeeId, queueId, tableId, checkId, tenderId, paymentId);
        }

        void IInterceptAlohaActivity2.ApplyComp(int managerId, int employeeId, int queueId, int tableId, int checkId, int compTypeId, int compId)
        {
            _service.ApplyComp(managerId, employeeId, queueId, tableId, checkId, compTypeId, compId);
        }

        void IInterceptAlohaActivity2.ApplyPayment(int managerId, int employeeId, int queueId, int tableId, int checkId, int tenderId, int paymentId)
        {
            _service.ApplyPayment(managerId, employeeId, queueId, tableId, checkId, tenderId, paymentId);
        }

        void IInterceptAlohaActivity2.ApplyPromo(int managerId, int employeeId, int queueId, int tableId, int checkId, int promotionId, int promoId)
        {
            _service.ApplyPromo(managerId, employeeId, queueId, tableId, checkId, promotionId, promoId);
        }


        void IInterceptAlohaActivity2.Bump(int tableId)
        {
            _service.Bump(tableId);
        }

        void IInterceptAlohaActivity2.CancelAddItem(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.CancelAddItem(employeeId, queueId, tableId, checkId, entryId);
        }


        void IInterceptAlohaActivity2.CarryoverId(int type, int oldId, int newId)
        {
            _service.CarryoverId(type, oldId, newId);
        }

        void IInterceptAlohaActivity2.ClockIn(int employeeId, string empName, int jobcodeId, string jobName)
        {
            _service.ClockIn(employeeId, empName, jobcodeId, jobName);
        }

        void IInterceptAlohaActivity2.ClockOut(int employeeId, string empName)
        {
            _service.ClockOut(employeeId, empName);
        }

        void IInterceptAlohaActivity2.CloseCheck(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.CloseCheck(employeeId, queueId, tableId, checkId);
        }

        void IInterceptAlohaActivity2.CloseTable(int employeeId, int queueId, int tableId)
        {
            _service.CloseTable(employeeId, queueId, tableId);
        }

        void IInterceptAlohaActivity2.CombineOrder(int employeeId, int srcQueueId, int srcTableId, int srcCheckId, int dstQueueId, int dstTableId, int dstCheckId)
        {
            _service.CombineOrder(employeeId, srcQueueId, srcTableId, srcCheckId, dstQueueId, dstTableId, dstCheckId);
        }

        void IInterceptAlohaActivity2.Custom(string name)
        {
            _service.Custom(name);
        }

        void IInterceptAlohaActivity2.DeleteComp(int managerId, int employeeId, int queueId, int tableId, int checkId, int compTypeId, int compId)
        {
            _service.DeleteComp(managerId, employeeId, queueId, tableId, checkId, compTypeId, compId);
        }

        void IInterceptAlohaActivity2.DeleteItems(int managerId, int employeeId, int queueId, int tableId, int checkId, int reasonId)
        {
            _service.DeleteItems(managerId, employeeId, queueId, tableId, checkId, reasonId);
        }

        void IInterceptAlohaActivity2.DeletePayment(int managerId, int employeeId, int queueId, int tableId, int checkId, int tenderId, int paymentId)
        {
            _service.DeletePayment(managerId, employeeId, queueId, tableId, checkId, tenderId, paymentId);
        }

        void IInterceptAlohaActivity2.DeletePromo(int managerId, int employeeId, int queueId, int tableId, int checkId, int promotionId, int promoId)
        {
            _service.DeletePromo(managerId, employeeId, queueId, tableId, checkId, promotionId, promoId);
        }


        void IInterceptAlohaActivity2.EndOfDay(int isMaster)
        {
            _service.EndOfDay(isMaster);
        }

        void IInterceptAlohaActivity2.EventNotification(int employeeId, int tableId, ALOHA_ACTIVITY_EVENT_NOTIFICATION_TYPES eventNotification)
        {
            _service.EventNotification(employeeId, tableId, eventNotification);
        }

        void IInterceptAlohaActivity2.HoldItems(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.HoldItems(employeeId, queueId, tableId, checkId);
        }

        void IInterceptAlohaActivity2.InitializationComplete()
        {
            _service.InitializationComplete();
        }

        void IInterceptAlohaActivity2.LockOrder(int tableId)
        {
            _service.LockOrder(tableId);
        }

        void IInterceptAlohaActivity2.LogIn(int employeeId, string name)
        {
            _service.LogIn(employeeId, name);
        }

        void IInterceptAlohaActivity2.LogOut(int employeeId, string name)
        {
            _service.LogOut(employeeId, name);
        }

        void IInterceptAlohaActivity2.ModifyItem(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.ModifyItem(employeeId, queueId, tableId, checkId, entryId);
        }

        void IInterceptAlohaActivity2.NameOrder(int employeeId, int queueId, int tableId, string name)
        {
            _service.NameOrder(employeeId, queueId, tableId, name);
        }

        void IInterceptAlohaActivity2.OnClockTick()
        {
            _service.OnClockTick();
        }

        void IInterceptAlohaActivity2.OpenCheck(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.OpenCheck(employeeId, queueId, tableId, checkId);
        }

        void IInterceptAlohaActivity2.OpenItem(int employeeId, int entryId, int itemId, string description, double price)
        {
            _service.OpenItem(employeeId, entryId, itemId, description, price);
        }

        void IInterceptAlohaActivity2.OpenTable(int employeeId, int queueId, int tableId, int tableDefId, string name)
        {
            _service.OpenTable(employeeId, queueId, tableId, tableDefId, name);
        }

        void IInterceptAlohaActivity2.OrderItems(int employeeId, int queueId, int tableId, int checkId, int modeId)
        {
            _service.OrderItems(employeeId, queueId, tableId, checkId, modeId);
        }

        void IInterceptAlohaActivity2.OrderScreen_TableCheckSeatChanged(int managerId, int employeeId, int queueId, int tableId, int checkId, int seatNum)
        {
            _service.OrderScreen_TableCheckSeatChanged(managerId, employeeId, queueId, tableId, checkId, seatNum);
        }

        void IInterceptAlohaActivity2.PostDeleteComp(int managerId, int employeeId, int queueId, int tableId, int checkId, int compTypeId, int compId)
        {
            _service.PostDeleteComp(managerId, employeeId, queueId, tableId, checkId, compTypeId, compId);
        }

        void IInterceptAlohaActivity2.PostDeleteItems(int managerId, int employeeId, int queueId, int tableId, int checkId, int reasonId)
        {
            _service.PostDeleteItems(managerId, employeeId, queueId, tableId, checkId, reasonId);
        }

        void IInterceptAlohaActivity2.PostDeletePromo(int managerId, int employeeId, int queueId, int tableId, int checkId, int promotionId, int promoId)
        {
            _service.PostDeletePromo(managerId, employeeId, queueId, tableId, checkId, promotionId, promoId);
        }

        void IInterceptAlohaActivity2.PreModifyItem(int employeeId, int queueId, int tableId, int checkId, int entryId)
        {
            _service.PreModifyItem(employeeId, queueId, tableId, checkId, entryId);
        }

        void IInterceptAlohaActivity2.RerouteDisplayBoard(int employeeId, int queueId, int tableId, int checkId, int displayBoardId, int controllingTerminalId, int defaultOrderModeOverride, int currentOrderOnly)
        {
            _service.RerouteDisplayBoard(employeeId, queueId, tableId, checkId, displayBoardId, controllingTerminalId, defaultOrderModeOverride, currentOrderOnly);
        }

        void IInterceptAlohaActivity2.SaveTab(int employeeId, int tableId, string name)
        {
            _service.SaveTab(employeeId, tableId, name);
        }

        void IInterceptAlohaActivity2.SetMasterTerminal(int terminalId)
        {
            _service.SetMasterTerminal(terminalId);
        }

        void IInterceptAlohaActivity2.SetQuickComboLevel(int employeeId, int queueId, int tableId, int checkId, int promotionId, int promoId, int nLevel, int nContext)
        {
            _service.SetQuickComboLevel(employeeId, queueId, tableId, checkId, promotionId, promoId, nLevel, nContext);
        }

        void IInterceptAlohaActivity2.Shutdown()
        {
            _service.Shutdown();
        }

        void IInterceptAlohaActivity2.SpecialMessage(int employeeId, int messageId, string message)
        {
            _service.SpecialMessage(employeeId, messageId, message);
        }

        void IInterceptAlohaActivity2.StartAddItem(int employeeId, int queueId, int tableId, int checkId, int entryId, int parentEntryId, int modCodeId, int itemId, string itemName, double itemPrice)
        {
            _service.StartAddItem(employeeId, queueId, tableId, checkId, entryId, parentEntryId, modCodeId, itemId, itemName, itemPrice);
        }

        void IInterceptAlohaActivity2.Startup(int hMainWnd)
        {
            _service.Startup(hMainWnd);
        }

        void IInterceptAlohaActivity2.TableToShowOnDispBChanged(int nTermId, int tableId)
        {
            _service.TableToShowOnDispBChanged(nTermId, tableId);
        }

        void IInterceptAlohaActivity2.TransferTable(int fromEmployeeId, int toEmployeeId, int tableId, string newName, int isGetCheck)
        {
            _service.TransferTable(fromEmployeeId, toEmployeeId, tableId, newName, isGetCheck);
        }

        void IInterceptAlohaActivity2.UnlockOrder(int tableId)
        {
            _service.UnlockOrder(tableId);
        }

        void IInterceptAlohaActivity2.UpdateItems(int employeeId, int queueId, int tableId, int checkId)
        {
            _service.UpdateItems(employeeId, queueId, tableId, checkId);
        }
    }
}
