@Code
    ViewData("Title") = "VW_OUTPUT_CPP"
    Layout = ""
End Code

<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/AUTHEN/FRM_CER_MAIN_CTRL.js"></script>

<div ng-controller="FRM_CER_MAIN_CTRL" ng-app="ANGULAR_APP">
    <div class="ic" style="font-family:'Taviraj'">
        <div class="part part-2-3 ic">
            <h1 style="text-align:center">คำขอหนังสือรับรองผลิตภัณฑ์ยา</h1>
            <p class="line-header"></p>
            <table width="100%" style="font-size:20px">
                <tr>
                    <td width="70%"></td>
                    <td width="7%" style="text-align:right">วันที่</td>
                    <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                </tr>
                <tr>
                    <td width="70%"></td>
                    <td width="7%" style="text-align:right">เขียนที่</td>
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
                    <td width="12%">ผู้รับอนุญาต</td>
                    <td width="35%"><input type="radio" id="ผลิตยา" name="md" value="1" />&nbsp;&nbsp;ผลิตยา/แบ่งบรรจุยา(manufacturer)</td>
                    <td width="20%"><input type="radio" id="นำหรือสั่งยา" name="md" value="2" />&nbsp;&nbsp;นำหรือสั่งยา(import)</td>
                    <td width="10%">ใบอนุญาตที่</td>
                    <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                </tr>
            </table>
            <table width="100%" style="font-size:20px">
                <tr>
                    <td width="45%">ชื่อสถานที่ผลิต/แบ่งบรรจุ/นำเข้า Product license holder</td>
                    <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                </tr>
            </table>
            <table width="100%" style="font-size:20px">
                <tr>
                    <td width="20%">ตั้งอยู่เลขที่ : Located at</td>
                    <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                </tr>
            </table>
            <table width="100%" style="font-size:20px">
                <tr>
                    <td width="57%">ชื่อสถานที่ผลิตในต่างประเทศ(กรณีนำสั่งฯ/แบ่งบรรจุ): Manufactured by</td>
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
                    <td width="25%">ประเภท (เลือกเพียง 1 ประเภท)</td>
                    <td width="7%"><input type="checkbox" ng-disabled="true" />&nbsp;&nbsp;CFS</td>
                    <td width="14%"><input type="checkbox" />&nbsp;&nbsp;CPP (แนวตั้ง)</td>
                    <td width="28%"><input type="checkbox" />&nbsp;&nbsp;CPP (WHO แบบขวาง 1 หน้า)</td>
                    <td width="19%"><input type="checkbox" />&nbsp;&nbsp;CPP (WHO 5 หน้า)</td>
                    <td width="4%">จำนวน</td>
                    <td width="10%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                    <td>ฉบับ</td>
                </tr>
            </table>
            <table width="100%" style="font-size:20px">
                <tr>
                    <td width="18%">ชื่อยา : Product name</td>
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
                    <td width="52%">เลือก/เพิ่มชื่อยาเพื่อการส่งออก : Name for export (it applicable)</td>
                    <td style="border-bottom:dotted;border-bottom-width:thin">
                        @*<select>
                        <option>1</option>
                    </select>*@
                    </td>
                </tr>
            </table>
            <table width="100%" style="font-size:20px">
                <tr>
                    <td width="65%">ประเทศที่นำเข้าผลิตภัณฑ์ (กรณีต้องการระบุในหนังสือรับรองฯ) : Importing Country</td>
                    <td style="border-bottom:dotted;border-bottom-width:thin">
                        @*<select>
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
                    <td width="24%">เลขทะเบียนที่ : Registered no.</td>
                    <td width="25%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                    <td width="29%">วันที่ออกเลขทะเบียน : Date of issue</td>
                    <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                </tr>
            </table>
            <table width="100%" style="font-size:20px">
                <tr>
                    <td width="60%">ตำรับยา : Formula Active Ingredient (s) and amount (s) per unit dose</td>
                    <td width="4%">Each</td>
                    <td width="20%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                    <td>contains</td>
                </tr>
            </table>
            <br />
            <table width="100%" style="font-size:20px">
                <tr>
                    <td width="10%">หมายเหตุ :</td>
                    <td>กรอกเป็นภาษาอังกฤษ กรณียาแผนโบราณ ให้แจ้งชื่อวิทยาศาสตร์ในสูตร ส่วนประกอบสำคัญ ข้าพเจ้าได้แนบ</td>
                </tr>
                <tr>
                    <td></td>
                    <td>หลักฐานมาด้วยคือ</td>
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
            <table width="100%" style="font-size:20px;border-color:#E5E2D8" border="1">
                <tr>
                    <td width="50%" align="center">
                        <form name="myForm">
                            <label>
                                <input type="radio" value="1" />
                                หนังสือรับรองรูปแบบทั่วไป
                            </label>
                            <label>&nbsp;&nbsp;&nbsp;</label>
                            <label>
                                <input type="radio" value="2" />
                                หนังสือรับรองที่มีเอกสารนอกเหนือจากสูตร (เช่น ฉลาก เอกสารกำกับยา เป็นต้น)
                            </label>
                        </form>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <table width="100%" style="font-size:20px">
                <tr>
                    <td width="35%"></td>
                    <td width="5%" style="text-align:right">ลงชื่อ</td>
                    <td width="20%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                    <td width="10%">ผู้ยื่นคำขอ</td>
                </tr>
                <tr>
                    <td width="35%"></td>
                    <td width="5%" style="text-align:right">ลงชื่อ</td>
                    <td width="20%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                    <td width="10%">ผู้บันทึกคำขอ</td>
                </tr>
            </table>
        </div>
    </div>
</div>