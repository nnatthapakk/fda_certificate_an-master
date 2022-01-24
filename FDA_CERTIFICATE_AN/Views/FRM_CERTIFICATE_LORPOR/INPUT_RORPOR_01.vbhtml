@Code
    ViewData("Title") = "INPUT_RORPOR_01"
End Code

<style>
    .title1 {
        width: 150px;
        height: 130px;
        /*background-color: aqua;*/
        text-align: center;
        border: solid;
        float: left;
    }

    .title2 {
        width: 400px;
        height: 120px;
        /*background-color:antiquewhite;*/
        text-align: center;
        border: solid;
        float: right;
    }

    .checkbox {
        width: 20px;
        height: 20px;
        margin-left: 45%;
        margin-top: 5%;
    }

    .hr {
        width: 95%;
        height: 10px;
        background-color: black;
    }

    .datepickerdemoBasicUsage {
        /** Demo styles for mdCalendar. */
    }

        .datepickerdemoBasicUsage md-content {
            padding-bottom: 200px;
        }

        .datepickerdemoBasicUsage .validation-messages {
            font-size: 12px;
            color: #dd2c00;
            margin-left: 15px;
        }
</style>

<div>
    <div class="ic" style="font-family:'Taviraj'">
        <div>
            <p style="text-align:right;font-size:20px">แบบ รผ. ๐๑</p>
        </div>
        <center>
            <h1>
                <b>คำขอหนังสือรับรองรุ่นการผลิตยาชีววัตถุสำหรับสัตว์</b>
            </h1>
        </center>
        <br />
        <table width="100%" style="font-family:'Taviraj';font-size:20px">
            <tr>
                <td style="text-align:right;width:80%">
                    เขียนที่
                </td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
            <tr>
                <td style="text-align:right;width:90px">
                    วันที่
                </td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <br />
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="22%">ข้าพเจ้า (นาย, นาง, นางสาว)</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
            <tr>
                <td width="22%"></td>
                <td style="text-align:center">(ผู้ดำเนินกิจการ)</td>
            </tr>
            <tr>
                <td width="22%">ในนามของ (บริษัท / ห้าง/ร้าน)</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
            <tr>
                <td width="22%"></td>
                <td style="text-align:center">(ผู้รับอนุญาต)</td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px ">
            <tr>
                <td width="25%">ตามใบอนุญาต (ผลิต/นำหรือสั่งฯ)</td>
                <td width="40%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                <td width="5%">เลขที่</td>
                <td width="10%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                <td>มีความประสงค์ขอหนังสือ</td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td>รับรองรุ่นการผลิตยาชีววัตถุสำหรับมนุษย์ ซึ่งออกตามความที่กำหนดในกฎกระทรวงว่าด้วยการรับรุ่นการผลิตยาแผนปัจจุบันที่เป็นยาชีววัตถุ พ.ศ.๒๕๕๓ โดยมีรายละเอียดของตำรับยาดังนี้</td>
            </tr>
            <tr>
                <td style="text-align:center">(๑ คำขอ ต่อ ๑ ทะเบียนตำรับยา ต่อ ๑ รุ่นการผลิต)</td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="2%"></td>
                <td width="17%">เลขทะเบียนตำรับยาที่</td>
                <td width="30%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                <td width="5%">ชื่อยา</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="2%"></td>
                <td width="25%">เลขแสดงรุ่นการผลิตที่บนขวดยา</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="2%"></td>
                <td width="40%">เลขแสดงรุ่นการผลิตที่บนขวดน้ำยาทำละลาย (ถ้ามี)</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="2%"></td>
                <td width="25%">เลขแสดงรุ่นการผลิตที่บนกล่องยา</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="2%"></td>
                <td width="10%">วันที่ผลิตยา</td>
                <td width="30%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                <td width="12%">วันที่ยาสิ้นอายุ</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="2%"></td>
                <td width="22%">วันที่ผลิตน้ำยาทำละลาย (ถ้ามี)</td>
                <td width="30%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                <td width="30%">วันที่ผลิตน้ำยาทำละลาย สิ้นอายุ (ถ้ามี)</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="2%"></td>
                <td width="50%">รายละเอียดขนาดบรรจุ (หากไม่พอโปรดจัดทำเป็นเอกสารแนบท้าย)</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="2%">&nbsp;</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="2%"></td>
                <td width="35%">รวมจำนวนที่ผลิตในประเทศ / นำหรือสั่งฯ ทั้งสิ้น</td>
                <td width="35%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                <td>(โด๊ส / ยูนิต / มิลลิลิตร / ขวด /หลอด)</td>
            </tr>
        </table>
        <div style="font-size:20px">ทั้งนี้ข้าพเจ้าในฐานะผู้รับอนุญาตขอรับรองว่าข้าพเจ้าและตำรับยาที่ยื่นคำขอครั้งนี้มีคุณสมบัติเป็นไปตามหลักเกณฑ์ที่กำหนดและได้แนบเอกสาร/หลักฐานประกอบพิจารณามาด้วยดังนี้</div>
        <div style="font-size:20px;margin-left:1.5em"><input type="checkbox" />&nbsp;สำเนาใบอนุญาตผลิตยาแผนปัจจุบัน หรือสำเนาใบอนุญาตนำหรือสั่งยาแผนปัจจุบัน แล้วแต่กรณี</div>
        <div style="font-size:20px;margin-left:1.5em"><input type="checkbox" />&nbsp;สำเนาใบสำคัญการขึ้นทะเบียนตำรับยา</div>
        <div style="font-size:20px;margin-left:1.5em"><input type="checkbox" />&nbsp;หนังสือรับรองรุ่นการผลิตที่ออกโดยผู้ผลิต</div>
        <div style="font-size:20px;margin-left:1.5em"><input type="checkbox" />&nbsp;หนังสือรับรองรุ่นการผลิตที่ออกโดยหน่วยงานของรัฐที่รับผิดชอบของประเทศผู้ผลิต (เฉพาะกรณีเป็นยานำหรือสั่งฯ)</div>
        <div style="font-size:20px;margin-left:1.5em"><input type="checkbox" />&nbsp;เอกสารสรุปกระบวนการผลิตของรุ่นการผลิตที่ยื่นคำขอ</div>
        <div style="font-size:20px;margin-left:1.5em"><input type="checkbox" />&nbsp;เอกสารแสดงวิธีการและรายละเอียดการขนส่ง</div>
        <div style="font-size:20px;margin-left:1.5em"><input type="checkbox" />&nbsp;เอกสารที่แสดงคุณภาพระหว่างการขนส่ง</div>
        <div style="font-size:20px;margin-left:1.5em"><input type="checkbox" />&nbsp;เอกสารอื่น ๆ (ถ้ามี โปรดระบุเป็นเอกสารแนบท้าย)</div>
        <br />
        <table width="50%" style="font-size:20px;float:right">
            <tr>
                <td width="5%">ลงชื่อ</td>
                <td width="50%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                <td>ผู้รับอนุญาต</td>
            </tr>
            <tr>
                <td width="5%" style="text-align:right">(</td>
                <td width="50%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                <td>) ตัวบรรจง</td>
            </tr>
        </table>
    </div>
</div>


