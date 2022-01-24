@Code
    ViewData("Title") = "FRM_CPP_MAIN"
End Code

<link rel="stylesheet" href="../dist/listree.min.css" />
<script src="../js/dist/listree.umd.min.js"></script>

<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/CPP/CPP_CTRL.js"></script>

<div ng-controller="CPP_CTRL" ng-app="ANGULAR_APP">
    <div class="content-part">
        <div class="part part-1-3 ic" style="font-family:'Taviraj'">
            <ul class="listree">
                <li>
                    <div class="listree-submenu-heading">
                        <b>คำขอหนังสือรับรองผลิตภัณฑ์ยา</b><br />
                        <b>(CERTIFICATE OF A PHARMACEUTICAL PRODUCT)</b>
                    </div>
                    <ul class="listree-submenu-items">
                        <li>
                            <a ng-click="DATA_CPP('950002')">CERTIFICATE OF A PHARMACEUTICAL PRODUCT(CPP) (แนวตั้ง)</a>
                        </li>
                        <li>
                            <a ng-click="DATA_CPP('950003')">CERTIFICATE OF A PHARMACEUTICAL PRODUCT(CPP) แบบ 1 หน้า (แนวขวาง)</a>
                        </li>
                        <li>
                            <a ng-click="DATA_CPP('950004')">CERTIFICATE OF A PHARMACEUTICAL PRODUCT(CPP) แบบ 5 หน้า</a>
                        </li>
                        <li>
                            <a ng-click="DATA_CPP('950001')">CERTIFICATE OF FREE SALE</a>
                        </li>
                    </ul>
                </li>
                <li>
                    <div class="listree-submenu-heading">
                        <b>หนังสือรับรองรุ่นการผลิตยาชีววัตถุสำหรับสัตว์</b><br />
                        <b>(CERTIFICATE OF LOT RELEASE)</b>
                    </div>
                    <ul class="listree-submenu-items">
                        @*<li>
                            <a ng-click="DATA_CPP('')">รผ.01</a>
                        </li>*@
                        <li>
                            <a ng-click="DATA_CPP('950102')">รผ.02 </a>
                        </li>
                        <li>
                            <a ng-click="DATA_CPP('950103')">รผ.03 </a>
                        </li>
                        <li>
                            <a ng-click="DATA_CPP('950104')">รผ.04 </a>
                        </li>
                        <li>
                            <a ng-click="DATA_CPP('950105')">รผ.05 </a>
                        </li>
                    </ul>
                </li>
                <li>
                    <div class="listree-submenu-heading"><b>TRANSLATION</b></div>
                    <ul class="listree-submenu-items">
                        <li>
                            <a ng-click="DATA_CPP('950007')">TRANSLATION MODERN REGISTRATION</a>
                        </li>
                        <li>
                            <a ng-click="DATA_CPP('950008')">TRANSLATION IMPORTING</a>
                        </li>
                        <li>
                            <a ng-click="DATA_CPP('950009')">TRANSLATION MANUFACTURING</a>
                        </li>
                        <li>
                            <a ng-click="DATA_CPP('950010')">TRANSLATION PLACE</a>
                        </li>
                    </ul>
                </li>
                <li>
                    <div class="listree-submenu-heading"><b>GxP CERTIFICATE</b></div>
                    <ul class="listree-submenu-items">
                        <li>
                            <a ng-click="DATA_CPP('950005')">GMP</a>
                        </li>
                        <li>
                            <a ng-click="DATA_CPP('950015')">GDP</a>
                        </li>
                        <li>
                            <a ng-click="DATA_CPP('950016')">GPP</a>
                        </li>
                    </ul>
                </li>
                <li>
                    <div class="listree-submenu-heading"><b>หนังสือรับรองตามประกาศกระทรวงพาณิชย์</b></div>
                    <ul class="listree-submenu-items">
                        <li>
                            <a ng-click="DATA_CPP('950202')">ช.ม.</a>
                        </li>
                        <li>
                            <a ng-click="DATA_CPP('950203')">ช.ส.</a>
                        </li>
                        <li>
                            <a ng-click="DATA_CPP('950201')">ช.ว.</a>
                        </li>
                    </ul>
                </li>
            </ul>
        </div>
        <div class="part part-2-3" style="font-family:'Taviraj'" ng-include="SUBPATH">
            <div>
                <div class="ic" style="font-family:'Taviraj'" >
                    
                </div>
            </div>
        </div>
    </div>
</div>