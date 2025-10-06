using ExecuteQueryCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using CSGenio.persistence;
using CSGenio.business;
using CSGenio.framework;
using Quidgest.Persistence.GenericQuery;
using Quidgest.Persistence;

namespace CSGenio.business
{
    public class ReindexFunctions
    {
        public PersistentSupport sp { get; set; }
        public User user { get; set; }
        public bool Zero { get; set; }

        public ReindexFunctions(PersistentSupport sp, User user, bool Zero = false) {
            this.sp = sp;
            this.user = user;
            this.Zero = Zero;
        }   

        public void DeleteInvalidRows(CancellationToken cToken) {
            List<int> zzstateToRemove = new List<int> { 1, 11 };
            DataMatrix dm;
            sp.openConnection();

            /* --- RMSMEM --- */
            dm = sp.Execute(
                new SelectQuery()
                .Select(CSGenioAmem.FldCodmem)
                .From(CSGenioAmem.AreaMEM)
                .Where(CriteriaSet.And().In(CSGenioAmem.FldZzstate, zzstateToRemove))
                );

            for (int i = 0; i < dm.NumRows; i++)
            {
                CSGenioAmem model = new CSGenioAmem(user);
                model.ValCodmem = dm.GetKey(i, 0);

                try
                {
                    model.delete(sp);
                }
                //Not every exception should be allowed to continue record deletion, only business exceptions need to be caught and allow to deletion continue.
                //If there are other types of exceptions, such as database connection problems, for example, execution should be stopped immediately
                catch(BusinessException ex)
                {
                    Log.Error((ex.UserMessage != null) ? ex.UserMessage : ex.Message);
                }
            }
                

            /* --- UserLogin --- */
            dm = sp.Execute(
                new SelectQuery()
                .Select(CSGenioApsw.FldCodpsw)
                .From(CSGenioApsw.AreaPSW)
                .Where(CriteriaSet.And().In(CSGenioApsw.FldZzstate, zzstateToRemove))
                );

            for (int i = 0; i < dm.NumRows; i++)
            {
                CSGenioApsw model = new CSGenioApsw(user);
                model.ValCodpsw = dm.GetKey(i, 0);

                try
                {
                    model.delete(sp);
                }
                //Not every exception should be allowed to continue record deletion, only business exceptions need to be caught and allow to deletion continue.
                //If there are other types of exceptions, such as database connection problems, for example, execution should be stopped immediately
                catch(BusinessException ex)
                {
                    Log.Error((ex.UserMessage != null) ? ex.UserMessage : ex.Message);
                }
            }
                

            /* --- AsyncProcess --- */
            dm = sp.Execute(
                new SelectQuery()
                .Select(CSGenioAs_apr.FldCodascpr)
                .From(CSGenioAs_apr.AreaS_APR)
                .Where(CriteriaSet.And().In(CSGenioAs_apr.FldZzstate, zzstateToRemove))
                );

            for (int i = 0; i < dm.NumRows; i++)
            {
                CSGenioAs_apr model = new CSGenioAs_apr(user);
                model.ValCodascpr = dm.GetKey(i, 0);

                try
                {
                    model.delete(sp);
                }
                //Not every exception should be allowed to continue record deletion, only business exceptions need to be caught and allow to deletion continue.
                //If there are other types of exceptions, such as database connection problems, for example, execution should be stopped immediately
                catch(BusinessException ex)
                {
                    Log.Error((ex.UserMessage != null) ? ex.UserMessage : ex.Message);
                }
            }
                

            /* --- NotificationEmailSignature --- */
            dm = sp.Execute(
                new SelectQuery()
                .Select(CSGenioAs_nes.FldCodsigna)
                .From(CSGenioAs_nes.AreaS_NES)
                .Where(CriteriaSet.And().In(CSGenioAs_nes.FldZzstate, zzstateToRemove))
                );

            for (int i = 0; i < dm.NumRows; i++)
            {
                CSGenioAs_nes model = new CSGenioAs_nes(user);
                model.ValCodsigna = dm.GetKey(i, 0);

                try
                {
                    model.delete(sp);
                }
                //Not every exception should be allowed to continue record deletion, only business exceptions need to be caught and allow to deletion continue.
                //If there are other types of exceptions, such as database connection problems, for example, execution should be stopped immediately
                catch(BusinessException ex)
                {
                    Log.Error((ex.UserMessage != null) ? ex.UserMessage : ex.Message);
                }
            }
                

            /* --- NotificationMessage --- */
            dm = sp.Execute(
                new SelectQuery()
                .Select(CSGenioAs_nm.FldCodmesgs)
                .From(CSGenioAs_nm.AreaS_NM)
                .Where(CriteriaSet.And().In(CSGenioAs_nm.FldZzstate, zzstateToRemove))
                );

            for (int i = 0; i < dm.NumRows; i++)
            {
                CSGenioAs_nm model = new CSGenioAs_nm(user);
                model.ValCodmesgs = dm.GetKey(i, 0);

                try
                {
                    model.delete(sp);
                }
                //Not every exception should be allowed to continue record deletion, only business exceptions need to be caught and allow to deletion continue.
                //If there are other types of exceptions, such as database connection problems, for example, execution should be stopped immediately
                catch(BusinessException ex)
                {
                    Log.Error((ex.UserMessage != null) ? ex.UserMessage : ex.Message);
                }
            }
                

            /* --- RMSU_PRF --- */
            dm = sp.Execute(
                new SelectQuery()
                .Select(CSGenioAu_prf.FldCodu_prf)
                .From(CSGenioAu_prf.AreaU_PRF)
                .Where(CriteriaSet.And().In(CSGenioAu_prf.FldZzstate, zzstateToRemove))
                );

            for (int i = 0; i < dm.NumRows; i++)
            {
                CSGenioAu_prf model = new CSGenioAu_prf(user);
                model.ValCodu_prf = dm.GetKey(i, 0);

                try
                {
                    model.delete(sp);
                }
                //Not every exception should be allowed to continue record deletion, only business exceptions need to be caught and allow to deletion continue.
                //If there are other types of exceptions, such as database connection problems, for example, execution should be stopped immediately
                catch(BusinessException ex)
                {
                    Log.Error((ex.UserMessage != null) ? ex.UserMessage : ex.Message);
                }
            }
                

            /* --- AsyncProcessArgument --- */
            dm = sp.Execute(
                new SelectQuery()
                .Select(CSGenioAs_arg.FldCodargpr)
                .From(CSGenioAs_arg.AreaS_ARG)
                .Where(CriteriaSet.And().In(CSGenioAs_arg.FldZzstate, zzstateToRemove))
                );

            for (int i = 0; i < dm.NumRows; i++)
            {
                CSGenioAs_arg model = new CSGenioAs_arg(user);
                model.ValCodargpr = dm.GetKey(i, 0);

                try
                {
                    model.delete(sp);
                }
                //Not every exception should be allowed to continue record deletion, only business exceptions need to be caught and allow to deletion continue.
                //If there are other types of exceptions, such as database connection problems, for example, execution should be stopped immediately
                catch(BusinessException ex)
                {
                    Log.Error((ex.UserMessage != null) ? ex.UserMessage : ex.Message);
                }
            }
                

            /* --- AsyncProcessAttachments --- */
            dm = sp.Execute(
                new SelectQuery()
                .Select(CSGenioAs_pax.FldCodpranx)
                .From(CSGenioAs_pax.AreaS_PAX)
                .Where(CriteriaSet.And().In(CSGenioAs_pax.FldZzstate, zzstateToRemove))
                );

            for (int i = 0; i < dm.NumRows; i++)
            {
                CSGenioAs_pax model = new CSGenioAs_pax(user);
                model.ValCodpranx = dm.GetKey(i, 0);

                try
                {
                    model.delete(sp);
                }
                //Not every exception should be allowed to continue record deletion, only business exceptions need to be caught and allow to deletion continue.
                //If there are other types of exceptions, such as database connection problems, for example, execution should be stopped immediately
                catch(BusinessException ex)
                {
                    Log.Error((ex.UserMessage != null) ? ex.UserMessage : ex.Message);
                }
            }
                

            /* --- UserAuthorization --- */
            dm = sp.Execute(
                new SelectQuery()
                .Select(CSGenioAs_ua.FldCodua)
                .From(CSGenioAs_ua.AreaS_UA)
                .Where(CriteriaSet.And().In(CSGenioAs_ua.FldZzstate, zzstateToRemove))
                );

            for (int i = 0; i < dm.NumRows; i++)
            {
                CSGenioAs_ua model = new CSGenioAs_ua(user);
                model.ValCodua = dm.GetKey(i, 0);

                try
                {
                    model.delete(sp);
                }
                //Not every exception should be allowed to continue record deletion, only business exceptions need to be caught and allow to deletion continue.
                //If there are other types of exceptions, such as database connection problems, for example, execution should be stopped immediately
                catch(BusinessException ex)
                {
                    Log.Error((ex.UserMessage != null) ? ex.UserMessage : ex.Message);
                }
            }
                
            
            //Hard Coded Tabels
            //These can be directly removed

            /* --- RMSmem --- */
            sp.Execute(new DeleteQuery()
                .Delete("RMSmem")
                .Where(CriteriaSet.And().In("RMSmem", "ZZSTATE", zzstateToRemove)));
                
            /* --- RMScfg --- */
            sp.Execute(new DeleteQuery()
                .Delete("RMScfg")
                .Where(CriteriaSet.And().In("RMScfg", "ZZSTATE", zzstateToRemove)));
                
            /* --- RMSlstusr --- */
            sp.Execute(new DeleteQuery()
                .Delete("RMSlstusr")
                .Where(CriteriaSet.And().In("RMSlstusr", "ZZSTATE", zzstateToRemove)));
                
            /* --- RMSlstcol --- */
            sp.Execute(new DeleteQuery()
                .Delete("RMSlstcol")
                .Where(CriteriaSet.And().In("RMSlstcol", "ZZSTATE", zzstateToRemove)));
                
            /* --- RMSlstren --- */
            sp.Execute(new DeleteQuery()
                .Delete("RMSlstren")
                .Where(CriteriaSet.And().In("RMSlstren", "ZZSTATE", zzstateToRemove)));
                
            /* --- RMSusrwid --- */
            sp.Execute(new DeleteQuery()
                .Delete("RMSusrwid")
                .Where(CriteriaSet.And().In("RMSusrwid", "ZZSTATE", zzstateToRemove)));
                
            /* --- RMSusrcfg --- */
            sp.Execute(new DeleteQuery()
                .Delete("RMSusrcfg")
                .Where(CriteriaSet.And().In("RMSusrcfg", "ZZSTATE", zzstateToRemove)));
                
            /* --- RMSusrset --- */
            sp.Execute(new DeleteQuery()
                .Delete("RMSusrset")
                .Where(CriteriaSet.And().In("RMSusrset", "ZZSTATE", zzstateToRemove)));
                
            /* --- RMSwkfact --- */
            sp.Execute(new DeleteQuery()
                .Delete("RMSwkfact")
                .Where(CriteriaSet.And().In("RMSwkfact", "ZZSTATE", zzstateToRemove)));
                
            /* --- RMSwkfcon --- */
            sp.Execute(new DeleteQuery()
                .Delete("RMSwkfcon")
                .Where(CriteriaSet.And().In("RMSwkfcon", "ZZSTATE", zzstateToRemove)));
                
            /* --- RMSwkflig --- */
            sp.Execute(new DeleteQuery()
                .Delete("RMSwkflig")
                .Where(CriteriaSet.And().In("RMSwkflig", "ZZSTATE", zzstateToRemove)));
                
            /* --- RMSwkflow --- */
            sp.Execute(new DeleteQuery()
                .Delete("RMSwkflow")
                .Where(CriteriaSet.And().In("RMSwkflow", "ZZSTATE", zzstateToRemove)));
                
            /* --- RMSnotifi --- */
            sp.Execute(new DeleteQuery()
                .Delete("RMSnotifi")
                .Where(CriteriaSet.And().In("RMSnotifi", "ZZSTATE", zzstateToRemove)));
                
            /* --- RMSprmfrm --- */
            sp.Execute(new DeleteQuery()
                .Delete("RMSprmfrm")
                .Where(CriteriaSet.And().In("RMSprmfrm", "ZZSTATE", zzstateToRemove)));
                
            /* --- RMSscrcrd --- */
            sp.Execute(new DeleteQuery()
                .Delete("RMSscrcrd")
                .Where(CriteriaSet.And().In("RMSscrcrd", "ZZSTATE", zzstateToRemove)));
                
            /* --- docums --- */
            sp.Execute(new DeleteQuery()
                .Delete("docums")
                .Where(CriteriaSet.And().In("docums", "ZZSTATE", zzstateToRemove)));
                
            /* --- RMSpostit --- */
            sp.Execute(new DeleteQuery()
                .Delete("RMSpostit")
                .Where(CriteriaSet.And().In("RMSpostit", "ZZSTATE", zzstateToRemove)));
                
            /* --- hashcd --- */
            sp.Execute(new DeleteQuery()
                .Delete("hashcd")
                .Where(CriteriaSet.And().In("hashcd", "ZZSTATE", zzstateToRemove)));
                
            /* --- RMSalerta --- */
            sp.Execute(new DeleteQuery()
                .Delete("RMSalerta")
                .Where(CriteriaSet.And().In("RMSalerta", "ZZSTATE", zzstateToRemove)));
                
            /* --- RMSaltent --- */
            sp.Execute(new DeleteQuery()
                .Delete("RMSaltent")
                .Where(CriteriaSet.And().In("RMSaltent", "ZZSTATE", zzstateToRemove)));
                
            /* --- RMStalert --- */
            sp.Execute(new DeleteQuery()
                .Delete("RMStalert")
                .Where(CriteriaSet.And().In("RMStalert", "ZZSTATE", zzstateToRemove)));
                
            /* --- RMSdelega --- */
            sp.Execute(new DeleteQuery()
                .Delete("RMSdelega")
                .Where(CriteriaSet.And().In("RMSdelega", "ZZSTATE", zzstateToRemove)));
                
            /* --- RMSTABDINAMIC --- */
            sp.Execute(new DeleteQuery()
                .Delete("RMSTABDINAMIC")
                .Where(CriteriaSet.And().In("RMSTABDINAMIC", "ZZSTATE", zzstateToRemove)));
                
            /* --- UserAuthorization --- */
            sp.Execute(new DeleteQuery()
                .Delete("UserAuthorization")
                .Where(CriteriaSet.And().In("UserAuthorization", "ZZSTATE", zzstateToRemove)));
                
            /* --- RMSaltran --- */
            sp.Execute(new DeleteQuery()
                .Delete("RMSaltran")
                .Where(CriteriaSet.And().In("RMSaltran", "ZZSTATE", zzstateToRemove)));
                
            /* --- RMSworkflowtask --- */
            sp.Execute(new DeleteQuery()
                .Delete("RMSworkflowtask")
                .Where(CriteriaSet.And().In("RMSworkflowtask", "ZZSTATE", zzstateToRemove)));
                
            /* --- RMSworkflowprocess --- */
            sp.Execute(new DeleteQuery()
                .Delete("RMSworkflowprocess")
                .Where(CriteriaSet.And().In("RMSworkflowprocess", "ZZSTATE", zzstateToRemove)));
                

            sp.closeConnection();
        }





        // USE /[MANUAL RDX_STEP]/
    }
}