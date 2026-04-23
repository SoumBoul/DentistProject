using System;
using System.Collections.Generic;
using DTO_Framwork;
using DAL_Framwork;

namespace BL_Framwork
{
    public  class InvoiceBL
    {
        private enum enMode { Addnew=1, update=2};
        enMode _Mode = enMode.Addnew;
        InvoiceDTO dto= new InvoiceDTO();

         InvoiceBL()
        {
            
            _Mode = enMode.Addnew;
        }
        public InvoiceBL(InvoiceDTO invoiceDto)
        {
            dto.Montant = invoiceDto.Montant;
            dto.Taxe = invoiceDto.Taxe;
            dto.MutuelleID = invoiceDto.MutuelleID;
            dto.RdvID = invoiceDto.RdvID;
            dto.InvoiceStatusID = invoiceDto.InvoiceStatusID;

            
        }


        static public int InsertInvoice(InvoiceDTO dto)
        {
            return InvoiceDAL.InsertInvoice(dto);
        }

        

         public bool Save()
        {
            switch(_Mode)
            {
                case enMode.Addnew:
                    InsertInvoice(dto);
                    _Mode = enMode.update;
                    return true;
                    break;

                case enMode.update:

                    break;

            }

            return false;



        }

    }
}
