@Code
    ViewData("Title") = "FRM_CERTIFICATE_STAFF_CONFIRM"
End Code

<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/AUTHEN/FRM_CER_MAIN_CTRL.js"></script>

<style>
    .t1 {
        height: 100%;
        width: 100%;
        border: solid;
        border-width: 1px;
    }
</style>

<div ng-controller="FRM_CER_MAIN_CTRL" ng-app="ANGULAR_APP" ng-init="loadcpp()">
    <div class="content-part" style="font-family:'Taviraj'">
        <div class="part part-2-3 ic">
            <div ng-include="VW_PATH">

            </div>
        </div>
        <div class="part part-1-3 ic">
            <div class="card">
                <table class="table">
                    <tr>
                        <td>รูปแบบใบ CER :</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>เลขที่รับ :</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>วันที่รับ :</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>Ref.No :</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>ชื่อ :</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>ทะเบียน :</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>ผู้ยื่น :</td>
                        <td></td>
                    </tr>
                </table>
                <br />
                <div>
                    แก้ไขหน่วย :
                </div>
                <div>
                    <input type="text" class="form-control" />
                </div>
                <br />
                <div>
                    วันอนุมัติ
                </div>
                <div style="text-align:center">
                    <md-datepicker ng-model="LIST_GMP.CER.DOCUMENT_DATE" md-placeholder="Enter date"
                                   input-aria-describedby="datepicker-description"
                                   input-aria-labelledby="datepicker-header">
                    </md-datepicker>
                </div>
                <br />
                <div>
                    ผู้อนุมัติ
                </div>
                <div>
                    <select class="form-control">
                        <option></option>
                    </select>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-6" style="text-align:center;width:100%;float:left">
                        <input type="button" class="form-control" value="ดูข้อมูลทะเบียน" />
                    </div>
                    <div class="col-sm-6" style="text-align:center;width:100%;float:right">
                        <input type="button" class="form-control" value="ดูข้อมูลใบอนุญาต" />
                    </div>
                </div>
                <br />
                <div class="col-sm-12" style="text-align:center;width:90%;margin-left:5%">
                    <input type="button" class="form-control" ng-click="BTN_RETURN()" value="คืนให้แก้ไขคำขอ" />
                </div>
                <br />
                <div class="col-sm-12" style="text-align:center;width:90%;margin-left:5%">
                    <input type="button" class="form-control" ng-click="BTN_WORK_GROUP()" value="เสนอลงนาม" />
                </div>
                <br />
                <div class="col-sm-12" style="text-align:center;width:90%;margin-left:5%">
                    <input type="button" class="form-control" value="อนุมัติ" />
                </div>
                <br />
                <div class="col-sm-12" style="text-align:center;width:90%;margin-left:5%">
                    <input type="button" class="form-control" ng-click="BTN_BACK()" value="กลับหน้ารายการ" />
                </div>
                <br />
                <div class="col-sm-12" style="text-align:center;width:90%;margin-left:5%">
                    <input type="button" class="form-control" ng-click="BTN_APPOINT()" value="ใบนัด" />
                </div>
                <br />
                <div class="col-sm-12" style="text-align:center;width:90%;margin-left:5%">
                    <input type="button" class="form-control" ng-click="" value="ดาวน์โหลด TEMPLATE ใบ CER" />
                </div>
                <br />
                <div class="col-sm-12" style="text-align:center;width:90%;margin-left:5%">
                    <input type="button" class="form-control" ng-click="" value="อัพโหลดใบ CER" />
                </div>
                <hr />
                <div>
                    <h4><b>มีไฟล์แนบดังนี้ :</b></h4>
                    1. สำเนาหนังสือรับรอง GMP<br />
                    2. เอกสารที่เป็นหลักฐานเกี่ยวข้อง เช่น สำเนาแบบ ท.ย.1 หน้า 1 และ 2 แบบ ก แก้ไขเปลี่ยนแปลงที่ได้รับอนุญาตในรายการที่เกี่ยวข้อง (เช่น แก้ไขชื่อยา สูตร เป็นต้น)
                </div>
            </div>
        </div>
    </div>
</div>