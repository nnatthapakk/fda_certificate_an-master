@Code
    ViewData("Title") = "FRM_CERTIFICATE_APPOINTMENT"
End Code

<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/AUTHEN/FRM_CER_MAIN_CTRL.js"></script>

<div ng-controller="FRM_CER_MAIN_CTRL" ng-app="ANGULAR_APP">
    <div class="ic">
        <div style="font-family:'Taviraj'">
            <br />
            <div class="row">
                <div class="col-sm-8" style="margin-left:5%">
                    <h3><b><i>CERTIFICATE OF A PHARMACEUTICAL PRODUCT(CPP)</i></b></h3>
                </div>
                <div class="col-sm-2">
                    <h4>เลขที่รับ :</h4>
                </div>
            </div>
            <br />
            <table class="table" border="1" style="width:80%;margin-left:10%">
                <tr>
                    <td width="20%" align="right">
                        วันที่นัดรับผลการอนุมัติ :
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td width="20%" align="right">
                        เลขดำเนินการ :
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td width="20%" align="right">
                        Ref. No. :
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td width="20%" align="right">
                        ผู้ประกอบการ :
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td width="20%" align="right">
                        ผู้บันทึกคำขอ :
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td width="20%" align="right">
                        เลขทะเบียน :
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td width="20%" align="right">
                        ชื่อยา :
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td width="20%" align="right">
                        จำนวนฉบับที่ :
                    </td>
                    <td></td>
                </tr>
            </table>
            <br />
            <table class="table" style="width:80%;margin-left:10%">
                <tr>
                    <td width="10%">
                        <h4><b><u>หมายเหตุ</u></b></h4>
                    </td>
                    <td>กรุณาพิมพ์บัตรรับคำขอเพื่อนำมาใช้ในการยื่นรับใบรับรอง CERTIFICATE ณ ศูนย์บริการสุขภาพเบ็ดเสร็จภายใน 5 วัน นับตั้งแต่วันที่อนุมัติ</td>
                </tr>
            </table>
        </div>
    </div>
</div>