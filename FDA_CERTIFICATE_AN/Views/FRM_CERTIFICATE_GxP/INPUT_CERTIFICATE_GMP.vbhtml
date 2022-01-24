@Code
    ViewData("Title") = "INPUT_CERTIFICATE_GMP"
End Code

<style>
    .border1 {
        height: 100%;
        width: 100%;
        border: solid;
        border-width: 4px;
    }
</style>
<div>
    <div class="ic" style="font-family:'Taviraj'">
        <table width="100%" style="font-size:24px;border-width:4px" border="1">
            <tr>
                <td style="text-align:center">แบบคำขอให้ออก GMP/GDP/FMP Certificate</td>
            </tr>
        </table>
        <br />
        <div class="border1">
            <table width="100%" style="font-size:20px;background-color:#D6DAD6" border="1">
                <tr>
                    <td style="text-align:center">ส่วนที่ 1 ผู้ยื่นคำขอ</td>
                </tr>
            </table>
            <br />
            <table width="30%" style="font-size:20px;float:right">
                <tr>
                    <td width="15%" style="text-align:right">วันที่</td>
                    <td width="30%">
                        <md-datepicker ng-model="" md-placeholder="Enter date"
                                       input-aria-describedby="datepicker-description"
                                       input-aria-labelledby="datepicker-header">
                        </md-datepicker>
                    </td>
                    <td width="10%"></td>
                </tr>
            </table>
            <br />
            <div style="font-size:20px;margin-left:10px"><b>เรื่อง</b><span style="padding-left:2em">ขอให้ออก GMP/GDP/FMP Certificate</span></div>
            <div style="font-size:20px;margin-left:10px"><b>เรียน</b><span style="padding-left:2em">หัวหน้ากลุ่มกำกับดูแลหลังออกสู่ตลาด</span></div>
            <table width="100%" style="font-size:20px">
                <tr>
                    <td width="10%"></td>
                    <td width="10%">ด้วยข้าพเจ้า</td>
                    <td width="55%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                    <td>ผู้ดำเนินกิจการของสถานที่</td>
                </tr>
            </table>
            <table width="100%" style="font-size:20px">
                <tr>
                    <td width="1%"></td>
                    <td width="25%"><input type="checkbox" />&nbsp;&nbsp;ผลิต /&nbsp;<input type="checkbox" />&nbsp;&nbsp;นำสั่ง /&nbsp;<input type="checkbox" />&nbsp;&nbsp;กระจายยา แผน</td>
                    <td width="20%"><input type="text" class="form-control" /></td>
                    <td width="3%">ชื่อ</td>
                    <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                    <td width="1%"></td>
                </tr>
            </table>
            <table width="100%" style="font-size:20px">
                <tr>
                    <td width="1%"></td>
                    <td width="10%">เลขที่ใบอนุญาต</td>
                    <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                    <td width="10%">เลขที่นิติบุคล</td>
                    <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                    <td width="1%"></td>
                </tr>
            </table>
            <table width="100%" style="font-size:20px">
                <tr>
                    <td width="1%"></td>
                    <td width="10%">ตั้งอยู่เลขที่</td>
                    <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                    <td width="1%"></td>
                </tr>
            </table>
            <table width="100%" style="font-size:20px">
                <tr>
                    <td width="1%"></td>
                    <td width="5%">โทรศัพท์</td>
                    <td width="25%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                    <td width="5%">โทรสาร</td>
                    <td width="25%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                    <td>มีความประสงค์จะ</td>
                </tr>
            </table>
            <div class="container">
                <div class="row">
                    <div style="float:left;width:50%">
                        <div style="font-size:20px;margin-left:5px">ขอให้ออก</div>
                        <div style="font-size:20px;margin-left:2em"><input type="checkbox" />&nbsp;&nbsp;GMP Certificate (แผนปัจจุบัน)</div>
                        <div style="font-size:20px;margin-left:2em"><input type="checkbox" />&nbsp;&nbsp;GMP Certificate (แผนโบราณ)</div>
                        <div style="font-size:20px;margin-left:2em"><input type="checkbox" />&nbsp;&nbsp;GDP Certificate (แผนปัจจุบัน)</div>
                        <div style="font-size:20px;margin-left:2em"><input type="checkbox" />&nbsp;&nbsp;GDP Certificate (แผนโบราณ)</div>
                        <div style="font-size:20px;margin-left:2em"><input type="checkbox" />&nbsp;&nbsp;FMP Certificate (แผนโบราณ ภาคผนวก ข)</div>
                        <div style="font-size:20px;margin-left:2em"><input type="checkbox" />&nbsp;&nbsp;FMP Certificate (แผนโบราณ ภาคผนวก ค)</div>
                    </div>
                    <div style="float:right;width:50%">
                        <div style="font-size:20px;margin-left:5px">สำหรับกรณี</div>
                        <div style="font-size:20px;margin-left:2em"><input type="checkbox" />&nbsp;&nbsp;ขอครั้งแรก หรือสิ้นสุดการรับรอง</div>
                        <div style="font-size:20px;margin-left:2em"><input type="checkbox" />&nbsp;&nbsp;เพิ่ม/ลดขอบข่ายการรับรอง</div>
                        <div style="font-size:20px;margin-left:2em"><input type="checkbox" />&nbsp;&nbsp;รับรองสำเนา</div>
                        <div style="font-size:20px;margin-left:2em"><input type="checkbox" />&nbsp;&nbsp;ขอใบแทน เนื่องจากฉบับเดิมสูญหาย</div>
                        <div style="font-size:20px;margin-left:2em"><input type="checkbox" />&nbsp;&nbsp;แก้ไขข้อความ</div>
                    </div>
                </div>
            </div>
            <br />
            <br />
            <div style="font-size:20px;margin-left:5px">พร้อมกันนี้ได้แนบ <b>หลักฐานประกอบคำขอฯ</b> มาพร้อมกับหนังสือฉบับนี้แล้ว ได้แก่</div>
            <div style="font-size:20px;margin-left:8em"><input type="checkbox" />&nbsp;&nbsp;สำเนา ใบอนุญาตผลิต/นาสั่งยา ฉบับปัจจุบัน</div>
            <div style="font-size:20px;margin-left:8em"><input type="checkbox" />&nbsp;&nbsp;สำเนา GMP/GDP/FMP Certificate ฉบับล่าสุด ภาษาไทยและภาษาอังกฤษ</div>
            <div style="font-size:20px;margin-left:8em"><input type="checkbox" />&nbsp;&nbsp;สำเนา หนังสือแจ้งผลการตรวจประเมินจากสำนักยา <u>กรณีผลการตรวจไม่พบข้อบกพร่อง</u></div>
            <div style="font-size:20px;margin-left:8em"><input type="checkbox" />&nbsp;&nbsp;สำเนา หนังสือแจ้งผลการพิจารณา Corrective Action จากสำนักยา ว่า Corrective Action ที่ท่านส่งมามีความเหมาะสม</div>
            <div style="font-size:20px;margin-left:9em">และให้ท่านสามารถยื่นคาขอให้ออก GMP/GDP/FMP Certificate ได้ <u>กรณีผลการตรวจพบข้อบกพร่อง</u></div>
            <div style="font-size:20px;margin-left:8em"><input type="checkbox" />&nbsp;&nbsp;GMP/GDP/FMP Certificate ฉบับล่าสุด ภาษาไทยและภาษาอังกฤษ</div>
            <div style="font-size:20px;margin-left:9em"><u>กรณีเพิ่ม/ลดขอบข่ายการรับรอง กรณีฉบับเดิมสูญหาย หรือกรณีแก้ไขเปลี่ยนแปลง</u></div>
            <div style="font-size:20px;margin-left:8em"><input type="checkbox" />&nbsp;&nbsp;ชื่อผู้รับอนุญาต และที่อยู่ภาษาอังกฤษ</div>
            <div style="font-size:20px;margin-left:8em"><input type="checkbox" />&nbsp;&nbsp;หนังสือมอบอานาจ</div>
            <div style="font-size:20px;margin-left:8em">
                <table width="100%">
                    <tr>
                        <td width="10%"><input type="checkbox" />&nbsp;&nbsp;อื่นๆ ได้แก่</td>
                        <td><input type="text" class="form-control" /></td>
                        <td width="1%"></td>
                    </tr>
                </table>
            </div>
            <br />
            <div style="font-size:20px;margin-left:8em">จึงเรียนมาเพื่อโปรดพิจารณาออกหนังสือรับรองดังกล่าว</div>
            <div style="font-size:20px;margin-left:8em"><input type="checkbox" />&nbsp;&nbsp;ฉบับภาษาไทย จำนวน 1 ฉบับ</div>
            <div style="font-size:20px;margin-left:8em"><input type="checkbox" />&nbsp;&nbsp;ฉบับภาษาอังกฤษ จำนวน 1 ฉบับ</div>
            <div style="font-size:20px;margin-left:8em">
                <table width="100%">
                    <tr>
                        <td width="25%"><input type="checkbox" />&nbsp;รับรองสำเนาภาษาอังกฤษ จำนวน</td>
                        <td width="20%"><input type="text" class="form-control" /></td>
                        <td>ฉบับ ด้วย</td>
                    </tr>
                </table>
            </div>
            <div style="font-size:20px;margin-left:8em">จะเป็นพระคุณ</div>
            <br />
            <br />
            <table width="100%" style="font-size:20px">
                <tr>
                    <td width="65%" style="text-align:right">ลงชื่อ</td>
                    <td width="20%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                    <td>ผู้ดำเนินกิจการ/ผู้แทน</td>
                </tr>
                <tr>
                    <td width="65%" style="text-align:right">(</td>
                    <td width="20%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                    <td style="text-align:left">)</td>
                </tr>
            </table>
            <br />
        </div>
        <br />
        <br />
        <div style="text-align:center">
            <button class="btn btn-lg" style="background-color:#71C970;color:white">บันทึก</button>
            <button class="btn btn-lg" style="background-color:#F9D759">ย้อนกลับ</button>
        </div>
    </div>
</div>
