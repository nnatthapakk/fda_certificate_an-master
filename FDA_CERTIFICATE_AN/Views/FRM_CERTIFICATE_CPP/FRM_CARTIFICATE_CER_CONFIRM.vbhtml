@Code
    ViewData("Title") = "FRM_CARTIFICATE_CER_CONFIRM"
End Code

<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/CPP/CPP_CTRL.js"></script>

<div @*ng-controller="CPP_CTRL" ng-app="ANGULAR_APP"*@>
    <div class="content-part" style="font-family:'Taviraj'">
        <div class="part part-2-3">
            <div class="ic">
                @*<div>
            <center>
                <a class="logo-site"><img src="../Images/layout/bird.png"></a>
            </center>
        </div>
        <br />*@
                <h1 style="text-align: center">คำขอหนังสือรับรองผลิตภัณฑ์ยา</h1>
                <p class="line-header"></p>
                <table style="width:100%;font-size:20px">
                    <tr>
                        <td width="35%"></td>
                        <td width="35%"></td>
                        <td width="6%" style="text-align:right">วันที่</td>
                        <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                    </tr>
                    <tr>
                        <td width="35%"></td>
                        <td width="35%"></td>
                        <td width="6%" style="text-align:right">เขียนที่</td>
                        <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                    </tr>
                </table>
                <br />
                <table width="100%" style="font-size:20px">
                    <tr>
                        <td width="10%" style="text-align:right" class="auto-style53">ข้าพเจ้า</td>
                        <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                    </tr>
                </table>
                <table width="100%" style="font-size:20px">
                    <tr>
                        <td width="10%">ผู้รับอนุญาต</td>
                        <td width="30%"><input type="radio" id="ผลิตยา" name="md" value="1" />&nbsp;&nbsp;ผลิตยา/แบ่งบรรจุยา(manufacturer)</td>
                        <td width="20%"><input type="radio" id="นำหรือสั่งยา" name="md" value="2" />&nbsp;&nbsp;นำหรือสั่งยา(import)</td>
                        <td width="9%">ใบอนุญาตที่</td>
                        <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                    </tr>
                </table>
                <table width="100%" style="font-size:20px">
                    <tr>
                        <td width="43%">ชื่อสถานที่ผลิต/แบ่งบรรจุ/นำเข้า Product license holder</td>
                        <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                    </tr>
                </table>
                <table width="100%" style="font-size:20px">
                    <tr>
                        <td width="18%">ตั้งอยู่เลขที่ : Located at</td>
                        <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                    </tr>
                </table>
                <table width="100%" style="font-size:20px">
                    <tr>
                        <td width="53%">ชื่อสถานที่ผลิตในต่างประเทศ(กรณีนำสั่งฯ/แบ่งบรรจุ): Manufactured by</td>
                        <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                    </tr>
                </table>
                <table width="100%" style="font-size:20px">
                    <tr>
                        <td width="10%">Located at</td>
                        <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                    </tr>
                </table>
                <br />
                <div style="font-size:20px;text-align:center">ขอให้สำนักยา สำนักงานคณะกรรมการอาหารและยาออกหนังสือรับรองผลิตภัณฑ์</div>
                <br />
                <table width="100%" style="font-size:20px">
                    <tr>
                        <td width="23%">ประเภท (เลือกเพียง 1 ประเภท)</td>
                        <td width="7%"><input type="checkbox" ng-disabled="true" />&nbsp;&nbsp;CFS</td>
                        <td width="14%"><input type="checkbox" />&nbsp;&nbsp;CPP (แนวตั้ง)</td>
                        <td width="26%"><input type="checkbox" />&nbsp;&nbsp;CPP (WHO แบบขวาง 1 หน้า)</td>
                        <td width="18%"><input type="checkbox" />&nbsp;&nbsp;CPP (WHO 5 หน้า)</td>
                        <td width="5%">จำนวน</td>
                        <td width="6%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                        <td>ฉบับ</td>
                    </tr>
                </table>
                <table width="100%" style="font-size:20px">
                    <tr>
                        <td width="17%">ชื่อยา : Product name</td>
                        <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                    </tr>
                </table>
                <br />
                <table width="100%" style="font-size:20px">
                    <tr>
                        <td><input type="checkbox" />&nbsp;&nbsp;เพิ่มชื่อเพื่อการส่งออก(แนบหลักฐานการได้รับอนุญาตประกอบด้วย)</td>
                    </tr>
                </table>
                <table width="100%" style="font-size:20px">
                    <tr>
                        <td width="2%"></td>
                        <td width="48%">เลือก/เพิ่มชื่อยาเพื่อการส่งออก : Name for export (it applicable)</td>
                        <td style="border-bottom:dotted;border-bottom-width:thin">
                            @*<select class="selectpicker">
                                <option>1</option>
                            </select>*@
                        </td>
                    </tr>
                </table>
                <table width="100%" style="font-size:20px">
                    <tr>
                        <td width="2%"></td>
                        <td width="62%">ประเทศที่นำเข้าผลิตภัณฑ์ (กรณีต้องการระบุในหนังสือรับรองฯ) : Importing Country</td>
                        <td style="border-bottom:dotted;border-bottom-width:thin">
                            @*<select class="selectpicker">
                                <option>1</option>
                            </select>*@
                        </td>
                    </tr>
                </table>
                <table width="100%" style="font-size:20px">
                    <tr>
                        <td width="20%">รูปแบบยา : dosage form</td>
                        <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                    </tr>
                </table>
                <table width="100%" style="font-size:20px">
                    <tr>
                        <td width="23%">เลขทะเบียนที่ : Registered no.</td>
                        <td width="20%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                        <td width="27%">วันที่ออกเลขทะเบียน : Date of issue</td>
                        <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                    </tr>
                </table>
                <div style="font-size:20px">ตำรับยา : Formula Active Ingredient (s) and amount (s) per unit dose</div>
                <table width="100%" style="font-size:20px">
                    <tr>
                        <td width="4%">Each</td>
                        <td width="20%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                        <td>contains</td>
                    </tr>
                </table>
                <table width="100%" style="font-size:20px">
                    <tr>
                        <td width="10%">หมายเหตุ :</td>
                        <td>กรอกเป็นภาษาอังกฤษ กรณียาแผนโบราณ ให้แจ้งชื่อวิทยาศาสตร์ในสูตร ส่วนประกอบสำคัญ ข้าพเจ้าได้แนบหลักฐานมาด้วยคือ</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>(1) สำเนาใบสำคัญการขึ้นทะเบียนตำรับยาหรือใบแทน</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>(2) สำเนาหนังสือรับรอง GMP</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>(3) เอกสารที่เป็นหลักฐานเกี่ยวข้อง เช่น สำเนาแบบ ท.ย.1 หน้า 1 และ 2 แบบ แก้ไขเปลี่ยนแปลงที่ได้ รับอนุญาตในรายการที่เกี่ยวข้อง (เช่น แก้ไขชื่อยา สูตร เป็นต้น)</td>
                    </tr>
                </table>
                <br />
                <br />
                <table width="100%" style="font-size:20px">
                    <tr>
                        <td width="25%"></td>
                        <td width="20%"></td>
                        <td width="5%" style="text-align:right">ลงชื่อ</td>
                        <td width="15%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                        <td width="10%">ผู้ยื่นคำขอ</td>
                    </tr>
                    <tr>
                        <td width="25%"></td>
                        <td width="20%"></td>
                        <td width="5%" style="text-align:right">ลงชื่อ</td>
                        <td width="15%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                        <td width="10%">ผู้บันทึกคำขอ</td>
                    </tr>
                </table>
            </div>
        </div>
        <div class="part part-1-3 ic">
            <div class="card">
                <table class="table">
                    <tr>
                        <td style="color:red;text-align:center"><h3><b>รอชำระเงิน</b></h3></td>
                    </tr>
                    <tr>
                        <td>
                            <button class="form-control"><span style="margin-right:7px" class="fa fa-paper-plane"></span>ออกใบสั่งชำระ</button>
                        </td>
                    </tr>
                </table>
                <table class="table">
                    <tr>
                        <td>ประเภท :</td>
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
                        <td>ผู้ยืน :</td>
                        <td></td>
                    </tr>
                </table>
                <br />
                <div class="col-sm-12" style="text-align:center;width:90%;margin-left:5%">
                    <input type="button" class="form-control" ng-click="BTN_SEND()" value="ส่งคำขอ" />
                </div>
                <br />
                <div class="col-sm-12" style="text-align:center;width:90%;margin-left:5%" ">
                    <input type="button" class="form-control" value="ยกเลิกคำขอ" />
                </div>
                <br />
                <div class="col-sm-12" style="text-align:center;width:90%;margin-left:5%">
                    <input type="button" class="form-control" ng-click="BTN_BACK()" value="กลับหน้ารายการ" />
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

