Imports System.Web.Mvc

Namespace Controllers
    Public Class FRM_CERTIFICATE_TRANSLATIONController
        Inherits Controller

        ' GET: FRM_CERTIFICATE_TRANSLATION
        Function Index() As ActionResult
            Return View()
        End Function
        Function INPUT_LOCATION_ENG_20() As ActionResult
            Return View()
        End Function
        Function INPUT_TRANSLATE_REGISTRATION() As ActionResult
            Return View()
        End Function

        Function FRM_CER_TRANSLATE_CONFIRM() As ActionResult
            Return View()
        End Function
        Function FILE_LOCATION_ENG_20_ATTACH() As ActionResult
            Return View()
        End Function
        Function VW_TRANSLATE_IMPORTER() As ActionResult
            Return View()
        End Function
        Function VW_TRANSLATE_MANUFACTURING() As ActionResult
            Return View()
        End Function
        Function VW_TRANSLATE_PLACE() As ActionResult
            Return View()
        End Function
    End Class
End Namespace