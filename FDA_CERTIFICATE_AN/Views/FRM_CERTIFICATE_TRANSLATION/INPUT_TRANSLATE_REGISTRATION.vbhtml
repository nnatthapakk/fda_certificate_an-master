@Code
    ViewData("Title") = "INPUT_TRANSLATE_REGISTRATION"
End Code

<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CPP/CPP_CTRL.js"></script>

<div class="ic" ng-controller="CPP_CTRL" ng-app="ANGULAR_APP">
    <div style="font-family:'Taviraj'">
        <center>
            <h3><b><u>คำขอหนังสือรับรองการแปลใบสำคัญการขึ้นทะเบียนตำรับยา</u></b></h3>
        </center>
    </div>
    <br />
    <table width="100%" style="font-family:'Taviraj';font-size:20px">
        <tr>
            <td style="text-align:right;width:80%">
                เขียนที่
            </td>
            <td><input type="text" class="form-control" /></td>
        </tr>
        <tr>
            <td style="text-align:right;width:90px">
                วันที่
            </td>
            <td>
                <md-datepicker ng-model="" md-placehoder="Enter date"
                               input-aria-describedby="datepicker-description"
                               input-aria-labelledby="datepicker-header">
                </md-datepicker>
            </td>
        </tr>
    </table>
    <br />
    <table width="100%" style="font-size:20px">
        <tr>
            <td width="5%"></td>
            <td width="22%">ข้าพเจ้า(นาย/นาง/นางสาว/บริษัท/หจก)</td>
            <td><input style="font-size:20px;font-family:'Taviraj';width:100%" class="form-control inline" /></td>
        </tr>
    </table>
    <table width="100%" style="font-size:20px">
        <tr>
            <td width="10%">ผู้รับอนุญาต</td>
            <td width="25%"><input type="checkbox" />&nbsp;&nbsp;ผลิต/แบ่งบรรจุ (Manufacturer)</td>
            <td width="23%"><input type="checkbox" />&nbsp;&nbsp;นำหรือสั่งยาฯ (Importer) ใบอนุญาตที่</td>
            <td><input style="font-size:20px;font-family:'Taviraj';width:100%" class="form-control inline" /></td>
        </tr>
    </table>
    <br />
    <h4><u>รายละเอียดด้านล่าง กรุณาออกเป็นภาษาอังกฤษ</u></h4>
    <table width="100%" style="font-size:20px">
        <tr>
            <td width="25%"><b>ชื่อผู้รับอนุญาตผลิต/แบ่งบรรจุ/นำหรือสั่งยาฯ</b></td>
            <td><input style="font-size:20px;font-family:'Taviraj';width:100%" class="form-control inline" /></td>
        </tr>
    </table>
    <table width="100%" style="font-size:20px">
        <tr>
            <td width="14%">ตั้งอยู่เลขที่: Located at</td>
            <td><input style="font-size:20px;font-family:'Taviraj';width:100%" class="form-control inline" /></td>
        </tr>
    </table>
    <table width="100%" style="font-size:20px">
        <tr>
            <td width="34%"><b>ชื่อผู้ผลิตยาสำเร็จรูป (Manufacturer of Finished Product)</b></td>
            <td><input style="font-size:20px;font-family:'Taviraj';width:100%" class="form-control inline" /></td>
        </tr>
    </table>
    <table width="100%" style="font-size:20px">
        <tr>
            <td width="14%">ตั้งอยู่เลขที่: Located at</td>
            <td><input style="font-size:20px;font-family:'Taviraj';width:100%" class="form-control inline" /></td>
        </tr>
    </table>
    <table width="100%" style="font-size:20px">
        <tr>
            <td width="31%"><b>ชื่อผู้แบ่งบรรจุ (Manufacturer of Primary Packging)</b></td>
            <td><input style="font-size:20px;font-family:'Taviraj';width:100%" class="form-control inline" /></td>
        </tr>
    </table>
    <table width="100%" style="font-size:20px">
        <tr>
            <td width="14%">ตั้งอยู่เลขที่: Located at</td>
            <td><input style="font-size:20px;font-family:'Taviraj';width:100%" class="form-control inline" /></td>
        </tr>
    </table>
    <table width="100%" style="font-size:20px">
        <tr>
            <td><b>ชื่อผู้ตรวจปล่อยหรือผ่านเพื่อจำหน่าย (Manufacturer responsible for Final Batch release)</b></td>
        </tr>
        <tr>
            <td><input style="font-size:20px;font-family:'Taviraj';width:100%" class="form-control inline" /></td>
        </tr>
    </table>
    <table width="100%" style="font-size:20px">
        <tr>
            <td width="14%">ตั้งอยู่เลขที่: Located at</td>
            <td><input style="font-size:20px;font-family:'Taviraj';width:100%" class="form-control inline" /></td>
        </tr>
    </table>
    <br />
    <table width="100%" style="font-size:20px">
        <tr>
            <td width="5%"></td>
            <td width="65%">ขอให้สำนักยา สำนักงานคณะกรรมการอาหารและยา ออกหนังสือรับรองการแปลใบสำคัญการขึ้นทะเบียนตำรับยา</td>
            <td width="5%">จำนวน</td>
            <td width="20%"><input style="font-size:20px;font-family:'Taviraj';width:100%" class="form-control inline" /></td>
            <td>ฉบับ</td>
        </tr>
    </table>
    <div style="font-size:20px;margin-left:3em"></div>
    <table width="100%" style="font-size:20px">
        <tr>
           
        </tr>
    </table>
    <table width="100%" style="font-size:20px">
        <tr>
            <td width="13%">ชื่อยา: Product Name</td>
            <td><input style="font-size:20px;font-family:'Taviraj';width:100%" class="form-control inline" /></td>
        </tr>
    </table>
    <table width="100%" style="font-size:20px">
        <tr>
            <td width="29%">เลขที่รับ: Application For Drug Registration No.</td>
            <td><input style="font-size:20px;font-family:'Taviraj';width:100%" class="form-control inline" /></td>
        </tr>
    </table>
    <table width="100%" style="font-size:20px">
        <tr>
            <td width="19%">เลขทะเบียนที่: Registration No.</td>
            <td width="27%"><input style="font-size:20px;font-family:'Taviraj';width:100%" class="form-control inline" /></td>
            <td width="24%">วันที่ออกเลขทะเบียนที่: Registration No.</td>
            <td><input style="font-size:20px;font-family:'Taviraj';width:100%" class="form-control inline" /></td>
        </tr>
    </table>
    <table width="100%" style="font-size:20px">
        <tr>
            <td width="15%">รูปแบบยา: Dosage Form</td>
            <td><input style="font-size:20px;font-family:'Taviraj';width:100%" class="form-control inline" /></td>
        </tr>
    </table>
    <table width="100%" style="font-size:20px">
        <tr>
            <td width="19%">ลักษณะยา: Product Description</td>
            <td><input style="font-size:20px;font-family:'Taviraj';width:100%" class="form-control inline" /></td>
        </tr>
    </table>
    <br />
    <div style="font-size:20px;margin-left:3em">ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ</div>
    <div style="font-size:20px;margin-left:5em">1.สำเนาใบสำคัญการขึ้นทะเบียนตำรับยาหรือใบแทน</div>
    <div style="font-size:20px;margin-left:5em">2.สำเนาใบอนุญาตผลิต/นำหรือสั่งยาฯ</div>
    <div style="font-size:20px;margin-left:5em">3.สำเนาหนังสือรับรอง GMP (ถ้ามี)</div>
    <div style="font-size:20px;margin-left:5em">4.เอกสารหลักฐานที่เกี่ยวข้อง (ถ้ามี) เช่น แบบ ก/ย.5 ที่ได้รับอนุญาตให้แก้ไขเปลี่ยนแปลงข้อมูลในส่วนที่เกี่ยวข้อง เป็นต้น</div>
    <br />
    <br />
    <table width="40%" style="font-size:20px;float:right">
        <tr>
            <td width="10%">ลงชื่อ</td>
            <td width="60%" style="border-bottom:dotted;border-bottom-width:thin"></td>
            <td>ผู้รับอนุญาต</td>
        </tr>
        <tr>
            <td width="10%" style="text-align:right">(</td>
            <td width="60%" style="border-bottom:dotted;border-bottom-width:thin"></td>
            <td>)</td>
        </tr>
    </table>
    @*<br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <div style="font-size:20px"><b>ตรวจสอบความถูกต้องและได้รับเอกสารแล้ว</b></div>
    <table width="50%" style="font-size:20px">
        <tr>
            <td width="25%">ผู้รับมอบอำนาจ</td>
            <td style="border-bottom:dotted;border-bottom-width:thin"></td>
        </tr>
    </table>
    <table width="50%" style="font-size:20px">
        <tr>
            <td width="10%">วันที่</td>
            <td style="border-bottom:dotted;border-bottom-width:thin"></td>
        </tr>
    </table>*@
    <br />
    <br />
    <br />
    <br />
    <br />
    <div class="col-sm-12" style="text-align:center;margin-bottom:40px;">
        <input type="button" class="btn btn-lg" style="background-color:#38A86B;color:white" ng-click="" value="บันทึก" />
        <input type="button" class="btn btn-lg" style="background-color:#FFD700" ng-click="BTN_BACK()" value="ย้อนกลับ" />
    </div>
</div>
