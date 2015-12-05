using System;
using ActivityPosEventLogger.Infrastructure;
using ActivityPosEventLogger.Model;
using LasaFOHLib;

namespace ActivityPosEventLogger.Service
{
    public class AlohaFunctionsService
    {
        public int GetTerminalId()
        {
            try
            {
                IIberObject localState = GetLocalState();
                return localState.GetLongVal(Constants.TERMINAL_NUMBER);
            }
            catch (Exception ex)
            {
                Logger.Exception(ex);
                return default(int);
            }
        }

        private static IberObject GetLocalState()
        {
            IberDepot depot = new IberDepotClass();
            return depot.GetEnum(Constants.INTERNAL_LOCALSTATE).First();
        }

        public PosEventEmployee GetEmployee(int iEmployeeId)
        {
            try
            {
                IIberObject localState = GetLocalState();
                IIberObject emp = localState.GetEnum(Constants.INTERNAL_LOCALSTATE_CUR_EMP).First();
                return new PosEventEmployee
                {
                    FirstName = emp.GetStringVal(Constants.FIRSTNAME),
                    LastName = emp.GetStringVal(Constants.LASTNAME),
                    Id = iEmployeeId
                };
            }
            catch (Exception ex)
            {
                Logger.Exception(ex);
                return PosEvent.GetEmployeeNotFound(iEmployeeId);
            }
        }

        public PosEventPayment GetPayment(int iCheckId, int iTenderId, int iPaymentId)
        {
            var depot = new IberDepot();
            var lastPayment = PosEvent.GetPaymentNotFound();

            try
            {
                foreach (IIberObject chkObject in depot.FindObjectFromId(Constants.INTERNAL_CHECKS, iCheckId))
                {
                    foreach (IIberObject objItem in chkObject.GetEnum(Constants.INTERNAL_PAYMENTS))
                    {
                        try
                        {
                            var id = objItem.GetLongVal("ID");
                            var tenderId = objItem.GetLongVal("TENDER_ID");
                            var amount = objItem.GetDoubleVal("AMOUNT");

                            if (id == iPaymentId)
                            {
                                return GetPaymentInfoById(iTenderId, depot, amount);
                            }


                            if (tenderId == iTenderId)
                            {
                                lastPayment = GetPaymentInfoById(iTenderId, depot, amount);
                            }
                        }
                        catch (Exception ex)
                        {
                            Logger.Exception(ex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Exception(ex);
            }

            return lastPayment;
        }

        private static PosEventPayment GetPaymentInfoById(int iTenderId, IberDepot depot, double amount)
        {
            foreach (IIberObject tender in depot.GetEnum(Constants.FILE_TENDER))
            {
                var idTender = tender.GetLongVal("ID");
                if (idTender == iTenderId)
                {
                    return new PosEventPayment
                    {
                        PaymentMethod = tender.GetStringVal("NAME"),
                        Amount = amount
                    };
                }
            }

            return PosEvent.GetPaymentNotFound();
        }


        public PosEventItem GetItemInfo(int iCheckId, int iEntryId)
        {
            try
            {
                foreach (IIberObject chkObject in new IberDepot().FindObjectFromId(Constants.INTERNAL_CHECKS, iCheckId))
                {
                    foreach (IIberObject objItem in chkObject.GetEnum(Constants.INTERNAL_CHECKS_ENTRIES))
                    {
                        try
                        {
                            var idEntry = objItem.GetLongVal("ID");
                            if (idEntry == iEntryId)
                            {
                                return new PosEventItem
                                {
                                    Id = objItem.GetLongVal("DATA"),
                                    Name = objItem.GetStringVal("DISP_NAME"),
                                    Price = objItem.GetDoubleVal("PRICE")
                                };
                            }
                        }
                        catch (Exception ex)
                        {
                            Logger.Exception(ex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Exception(ex);
            }

            return PosEvent.GetItemNotFound();

        }

        public PosEventComp GetComp(int iCompTypeId, int iCompId)
        {
            try
            {
                foreach (IIberObject obj in new IberDepot().GetEnum(5))
                {
                    var id = obj.GetLongVal("ID");
                    if (id == iCompTypeId)
                    {
                        return new PosEventComp
                        {
                            CompDesc = obj.GetStringVal("NAME"),
                            CompTypeId = iCompTypeId
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Exception(ex);
            }

            return PosEvent.GetCompNotFound();
        }

        public PosEventPromo GetPromo(int iPromotionId, int iPromoId)
        {
            try
            {
                foreach (IIberObject obj in new IberDepot().GetEnum(21))
                {
                    var id = obj.GetLongVal("ID");
                    if (id == iPromotionId)
                    {
                        return new PosEventPromo
                        {
                            PromoDesc = obj.GetStringVal("NAME"),
                            PromotionId = iPromotionId
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Exception(ex);
            }

            return PosEvent.GetPromotionNotFound();
        }
    }
}
