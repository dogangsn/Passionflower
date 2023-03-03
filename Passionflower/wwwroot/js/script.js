var globlefuncgeneral = {
    gameover_text: "",
    wheel_text_color: "",
    wheel_stroke_color: "",
    segmentsForSpin: [],
    arrSegmentsList: [],
    theWheel: [],
    actual_JSON: [],
    arrsp: [],
    strarr: "",
    cookidy: 0,
    wheelPower: 0,
    wheelSpinning: !1
};

function init() {
    var e = getCookie("canspin");
    "" != e ? "no" == e ? ($("#spin_button").removeAttr("onclick"), $(".power_controls").hide(), $(".reset_btn").show()) : ($(".power_controls").show(), $(".reset_btn").hide()) : $(".power_controls").show(), loadJSON(function (e) {
        globlefuncgeneral.actual_JSON = JSON.parse(e);
        var t = globlefuncgeneral.actual_JSON.data[0].segmentsList;
        globlefuncgeneral.cookidy = globlefuncgeneral.actual_JSON.data[0].cookiedays;
        var a = globlefuncgeneral.actual_JSON.data[0].centerWheelImage,
            l = globlefuncgeneral.actual_JSON.data[0].WheelPinImage,
            o = globlefuncgeneral.actual_JSON.data[0].backgroundOption,
            n = globlefuncgeneral.actual_JSON.data[0].IntroText;
        if ($(".power_controls .title").html(n), "" != l) {
            var r = "images/" + l;
            $(".spin_pin").css({
                "background-repeat": "no-repeat",
                "background-image": "url(" + r + ")"
            })
        }
        if ("" != a) {
            var d = "images/" + a;
            $(".wheel_inner").css({
                "background-image": "url(" + d + ")"
            })
        }
        var u = o.type,
            s = o.value;
        if ("text" == u) $(".bgMaindiv").css("background-color", s);
        else {
            var c = "images/" + s;
            $(".bgMaindiv").css({
                "background-size": "100% auto",
                "background-repeat": "no-repeat",
                "background-image": "url(" + c + ")"
            })
        }
        var g = 1;
        for (i = 0; i < t.length; i++) {
            globlefuncgeneral.segmentsForSpin.push(t[i].txtDisplayText);
            for (var p = parseInt(t[i].hdnGravityPerc) / 10, h = Math.round(p), v = 0; v < h; v++) globlefuncgeneral.arrsp.push(g);
            globlefuncgeneral.arrSegmentsList.push({
                fillStyle: t[i].txtBackgroundColor,
                text: t[i].txtDisplayText,
                winResult: t[i].txtResultText,
                isCouponExist: t[i].IsCouponCode,
                CouponCode: t[i].CouponCode
            }), g += 1
        }
        globlefuncgeneral.strarr = globlefuncgeneral.arrsp.join("|")
    }), drawMySpinWheel()
}

function drawMySpinWheel() {
    setTimeout(function () {
        if (globlefuncgeneral.arrSegmentsList.length > 0) {
            var e = null != globlefuncgeneral.actual_JSON.data[0].WheelTextSize && "" != globlefuncgeneral.actual_JSON.data[0].WheelTextSize && void 0 != globlefuncgeneral.actual_JSON.data[0].WheelTextSize ? globlefuncgeneral.actual_JSON.data[0].WheelTextSize : 50;
            globlefuncgeneral.gameover_text = null != globlefuncgeneral.actual_JSON.data[0].GameOverText && "" != globlefuncgeneral.actual_JSON.data[0].GameOverText && void 0 != globlefuncgeneral.actual_JSON.data[0].GameOverText ? globlefuncgeneral.actual_JSON.data[0].GameOverText : "", globlefuncgeneral.wheel_text_color = null != globlefuncgeneral.actual_JSON.data[0].WheelTextColor && "" != globlefuncgeneral.actual_JSON.data[0].WheelTextColor && void 0 != globlefuncgeneral.actual_JSON.data[0].WheelTextColor ? globlefuncgeneral.actual_JSON.data[0].WheelTextColor : "#000000", globlefuncgeneral.wheel_stroke_color = null != globlefuncgeneral.actual_JSON.data[0].WheelStrokeColor && "" != globlefuncgeneral.actual_JSON.data[0].WheelStrokeColor && void 0 != globlefuncgeneral.actual_JSON.data[0].WheelStrokeColor ? globlefuncgeneral.actual_JSON.data[0].WheelStrokeColor : "#000000", wheel_stroke_width = null != globlefuncgeneral.actual_JSON.data[0].WheelStrokeWidth && "" != globlefuncgeneral.actual_JSON.data[0].WheelStrokeWidth && void 0 != globlefuncgeneral.actual_JSON.data[0].WheelStrokeWidth ? globlefuncgeneral.actual_JSON.data[0].WheelStrokeWidth : "3", wheel_inner_radious = null != globlefuncgeneral.actual_JSON.data[0].InnerRadius && "" != globlefuncgeneral.actual_JSON.data[0].InnerRadius && void 0 != globlefuncgeneral.actual_JSON.data[0].InnerRadius ? globlefuncgeneral.actual_JSON.data[0].InnerRadius : "212", wheel_outer_radious = null != globlefuncgeneral.actual_JSON.data[0].OuterRadius && "" != globlefuncgeneral.actual_JSON.data[0].OuterRadius && void 0 != globlefuncgeneral.actual_JSON.data[0].OuterRadius ? globlefuncgeneral.actual_JSON.data[0].OuterRadius : "60", globlefuncgeneral.theWheel = new Luckywheel({
                numSegments: globlefuncgeneral.arrSegmentsList.length,
                outerRadius: parseInt(wheel_outer_radious),
                innerRadius: parseInt(wheel_inner_radious),
                textFontSize: e,
                textMargin: 0,
                segments: globlefuncgeneral.arrSegmentsList,
                wheelTextColor: globlefuncgeneral.wheel_text_color,
                WheelStrokeColor: globlefuncgeneral.wheel_stroke_color,
                WheelStrokeWidth: wheel_stroke_width,
                animation: {
                    type: "spinToStop",
                    duration: 5,
                    spins: 8,
                    callbackFinished: alertWinResult,
                    callbackAfter: function () {
                        jQuery(".spin_pin").rotate(-10)
                    },
                    callbackSound: function () {
                        jQuery(".spin_pin").rotate(-20), t.play()
                    }
                }
            });
            var t = new Audio("../Media/spinsound.mp3")
        }
    }, 500)
}

function selectedSpeed(e) {
    0 == globlefuncgeneral.wheelSpinning && (e >= 1 && (document.getElementById("lowspeed").className = "lowspeed"), document.getElementById("mediumspeed").className = e >= 2 ? "mediumspeed" : "", document.getElementById("highspeed").className = e >= 3 ? "highspeed" : "", globlefuncgeneral.wheelPower = e, document.getElementById("spin_button").src = "spin_on.png", document.getElementById("spin_button").className = "clickable")
}

function alertWinResult(e) {
    jQuery(".spin_pin").rotate(0),
        $("#spinWinResult").text(globlefuncgeneral.gameover_text),
        $(".power_controls").hide();
    var t = "";
    "true" == e.isCouponExist ? (t += "<p>" + e.winResult + "</p>", t += "<p> Your Coupon Code is " + e.CouponCode + "</p>") : t += "<p>" + e.winResult + "</p>", $("#displayprice").html(t), $("#spin").modal("show")
        , $(".reset_btn").show(), $('#startConfetti').click()

    $("#spin").on('hide.bs.modal', function () {
        $('#confettiCanvas').remove();
    });
}



function loadJSON(e) {
    try {
        if ("localhost:44394" == window.location.host) e('{"data":[{"segmentsList":[],"OuterRadius":"212","InnerRadius":"60","WheelStrokeColor":"#FFFFFF","WheelStrokeWidth":"3","WheelTextColor":"#FFFFFF","WheelTextSize":"20","GameOverText":"","IntroText":"","backgroundOption":{"type":"image","value":""},"centerWheelImage":"wheelcenter_b8aba481386aabee47bb588032606137.png","WheelPinImage":"wheelcenter_42b535480fd11de938ec249bf2b60678.png","enablediscountbar":"on","countdowntime":"15","position":"screen_bottom","showdesktop":"on","desktopintent":"on","desktopinterval":"on","DesktopIntervaltext":"17","showmobile":"off","mobileintent":"on","mobileinterval":"on","MobileIntervaltext":"19","cookiedays":"5"}]}');
        else {
            var t = new XMLHttpRequest;
            t.overrideMimeType("application/json"), t.open("GET", "settings.json", !0), t.onreadystatechange = function () {
                4 == t.readyState && "200" == t.status && e(t.responseText)
            }, t.send(null)
        }
    } catch (e) { }
}

function setCookie(e, t, a) {
    var l = new Date;
    l.setTime(l.getTime() + 24 * a * 60 * 60 * 1e3);
    var o = "expires=" + l.toUTCString();
    document.cookie = e + "=" + t + ";" + o + ";path=/"
}

function getCookie(e) {
    for (var t = e + "=", a = document.cookie.split(";"), l = 0; l < a.length; l++) {
        for (var o = a[l];
            " " == o.charAt(0);) o = o.substring(1);
        if (0 == o.indexOf(t)) return o.substring(t.length, o.length)
    }
    return ""
}

function formSaveData() {
    var e = [],
        t = [];
    globlefuncgeneral.arrsp = [];
    var a = 1;

    $("#tblsegments tr").each(function () {
        for (
            var l = $(this).attr("data-count"),
            o = $(this).find("#txtDisplayText" + l).val(),
            n = "#" + $(this).find("#txtBackgroundColor" + l).val(),
            r = $(this).find("#txtResultText" + l).val(),
            i = $(this).find("#txtCouponCodeText" + l).val(),
            d = $(this).find("input[name='chkCouponCode" + l + "']").val(),
            u = $(this).find("#ddl_gravity" + l).val(),
            s = $(this).find("#hdnGravityPerc" + l).val(),
            c = parseInt(s) / 10,
            g = Math.round(c),
            p = 0; p < g; p++
        )
            globlefuncgeneral.arrsp.push(a);
        a += 1, e.push({
            CouponCode: i,
            IsCouponCode: "yes" == d ? "true" : "false",
            ddlGravity: u,
            hdnGravityPerc: s,
            txtBackgroundColor: n,
            txtDisplayText: o,
            txtResultText: r
        }), t.push({
            fillStyle: n,
            text: o,
            winResult: r,
            isCouponExist: "yes" == d ? "true" : "false",
            CouponCode: i
        })
    }),
        globlefuncgeneral.arrSegmentsList = t,
        globlefuncgeneral.actual_JSON.data[0].segmentsList = e,
        globlefuncgeneral.actual_JSON.data[0].OuterRadius = $("#txtOuterRadius").val(),
        globlefuncgeneral.actual_JSON.data[0].InnerRadius = $("#txtInnerRadius").val(),
        globlefuncgeneral.actual_JSON.data[0].WheelStrokeWidth = $("#txtWheelStrokeWidth").val(),
        globlefuncgeneral.actual_JSON.data[0].WheelTextSize = $("#txtwheelTextSize").val(),
        globlefuncgeneral.actual_JSON.data[0].GameOverText = $("#txtgameOverText").val(),
        globlefuncgeneral.actual_JSON.data[0].IntroText = $("#txtintroText").val(),
        globlefuncgeneral.actual_JSON.data[0].IntroText = $("#txtintroText").val(),
        $(".power_controls .title").html($("#txtintroText").val()), $(".spin_pin").css({
            "background-repeat": "no-repeat",
            "background-image": "url(" + $("#txtWheelPinImage").val() + ")"
        }),
        $(".wheel_inner").css({
            "background-image": "url(" + $("#txtWheelCenterImage").val() + ")"
        }),
        globlefuncgeneral.actual_JSON.data[0].WheelStrokeColor = "#" + $("#txtWheelStrokeColor").val(),
        globlefuncgeneral.actual_JSON.data[0].WheelTextColor = "#" + $("#txtwheelTextColor").val(),
        "text" == $("#ddlBackgroundOption").val() ? $(".bgMaindiv").css("background-color", "#" + $("#txtBackgroundColor").val()) : $(".bgMaindiv").css({
            "background-size": "100% auto",
            "background-repeat": "no-repeat",
            "background-image": "url(" + $("#txtBackgroungImage").val() + ")"
        }), drawMySpinWheel(), $("html, body").animate({
            scrollTop: 0
        }, "slow")
}

function SetJSONvalues() {
    setTimeout(function () {
        var e = "http://luckyspin.aliansoftware.net/";
        $("#txtOuterRadius").val(globlefuncgeneral.actual_JSON.data[0].OuterRadius),
            $("#txtInnerRadius").val(globlefuncgeneral.actual_JSON.data[0].InnerRadius),
            $("#txtWheelStrokeWidth").val(globlefuncgeneral.actual_JSON.data[0].WheelStrokeWidth),
            $("#txtwheelTextSize").val(globlefuncgeneral.actual_JSON.data[0].WheelTextSize),
            $("#txtgameOverText").val(globlefuncgeneral.actual_JSON.data[0].GameOverText),
            $("#txtintroText").val(globlefuncgeneral.actual_JSON.data[0].IntroText);

        var t = e + "/images/" + globlefuncgeneral.actual_JSON.data[0].centerWheelImage,
            a = e + "/images/" + globlefuncgeneral.actual_JSON.data[0].WheelPinImage;
        $("#txtWheelCenterImage").val(t), $("#txtWheelPinImage").val(a), $("#txtWheelStrokeColor").val(globlefuncgeneral.actual_JSON.data[0].WheelStrokeColor.split("#")[1]), $("#txtwheelTextColor").val(globlefuncgeneral.actual_JSON.data[0].WheelTextColor.split("#")[1]);
        var l = globlefuncgeneral.actual_JSON.data[0].backgroundOption.type,
            o = globlefuncgeneral.actual_JSON.data[0].backgroundOption.value;
        if ($("#ddlBackgroundOption").val(l), "text" == l) $("#dvBackgroundColor").show(), $("#dvBackgroundImage").hide(), $("#txtBackgroundColor").val(o.split("#")[1]);
        else {
            $("#dvBackgroundColor").hide(), $("#dvBackgroundImage").show();
            var n = e + "/images/" + o;
            $("#txtBackgroungImage").val(n)
        }
        $("#countdowntime").val(globlefuncgeneral.actual_JSON.data[0].countdowntime),
            $("#position").val(globlefuncgeneral.actual_JSON.data[0].position),
            "on" == globlefuncgeneral.actual_JSON.data[0].enablediscountbar ? $("#enablediscountbar").prop("checked", !0).trigger("change") : $("#enablediscountbar").prop("checked", !1).trigger("change"),
            "on" == globlefuncgeneral.actual_JSON.data[0].showdesktop ? ($("#showdesktop").prop("checked", !0), $("#dvdesktop").removeClass("disabled").removeAttr("disabled")) : ($("#showdesktop").prop("checked", !1), $("#dvdesktop").addClass("disabled").attr("disabled")),
            "on" == globlefuncgeneral.actual_JSON.data[0].desktopintent ? $("#desktopintent").prop("checked", !0) : $("#desktopintent").prop("checked", !1),
            "on" == globlefuncgeneral.actual_JSON.data[0].desktopinterval ? $("#desktopinterval").prop("checked", !0) : $("#desktopinterval").prop("checked", !1),
            $("#DesktopIntervaltext").val(globlefuncgeneral.actual_JSON.data[0].DesktopIntervaltext), "on" == globlefuncgeneral.actual_JSON.data[0].showmobile ? ($("#showmobile").prop("checked", !0),
                $("#dvmobile").removeClass("disabled").removeAttr("disabled")) : ($("#showmobile").prop("checked", !1), $("#dvmobile").addClass("disabled").attr("disabled")), "on" == globlefuncgeneral.actual_JSON.data[0].mobileintent ? $("#mobileintent").prop("checked", !0) : $("#mobileintent").prop("checked", !1), "on" == globlefuncgeneral.actual_JSON.data[0].mobileinterval ? $("#mobileinterval").prop("checked", !0) : $("#mobileinterval").prop("checked", !1), $("#MobileIntervaltext").val(globlefuncgeneral.actual_JSON.data[0].MobileIntervaltext), $("#cookiedays").val(globlefuncgeneral.actual_JSON.data[0].cookiedays);
        var r = globlefuncgeneral.actual_JSON.data[0].segmentsList;
        if (r.length > 0) {
            var i = "",
                d = 1;
            $.each(r, function () {
                i += '<tr id="dvdelete_' + d + '" class="clscombinations" data-count="' + d + '">', i += '<td width="20%">', i += '<input type="text" id="txtDisplayText' + d + '" name="txtDisplayText' + d + '" class="token_input input_box" placeholder="Enter Segment Name" value="' + this.txtDisplayText + '">', i += '<span id="spn_DisplayText' + d + '" name="spn_DisplayText' + d + '" class="frmError"> This field is required. </span>', i += "</td>", i += '<td width="10%">', i += '<input type="text" id="txtBackgroundColor' + d + '" name="txtBackgroundColor' + d + '" class="token_input input_box jscolor" placeholder="Select Background Color" value="' + this.txtBackgroundColor + '" autocomplete="off">', i += "</td>", i += '<td width="20%">', i += '<input type="text" id="txtResultText' + d + '" name="txtResultText' + d + '" class="token_input input_box" placeholder="Enter Result Text" value="' + this.txtResultText + '">', i += '<span id="spn_ResultText' + d + '" name="spn_ResultText' + d + '" class="frmError"> This field is required. </span>', i += "</td>", i += '<td width="40%">', i += '<div style="text-align: left;">', i += '<span style="text-align: left;"> Have a coupon code ? </span>', i += "</div>", i += '<div style="text-align: left;">', i += '<input type="radio" name="chkCouponCode' + d + '" value="Yes" ' + ("true" == this.IsCouponCode ? 'checked="checked"' : "") + '  data-id="' + d + '" class="clsCouponCode"> Yes', i += '<input type="radio" name="chkCouponCode' + d + '" value="No" ' + ("false" == this.IsCouponCode ? 'checked="checked"' : "") + ' data-id="' + d + '" class="clsCouponCode"> No', i += "</div>", i += '<input type="text" id="txtCouponCodeText' + d + '" name="txtCouponCodeText' + d + '" class="token_input input_box" placeholder="Enter Coupon Code" value="' + this.CouponCode + '" style="display:' + ("true" == this.IsCouponCode ? "block" : "none") + '">', i += "</td>", i += '<td width="20%">', i += '<div class="copon_pr">', i += '<select id="ddl_gravity' + d + '" name="ddl_gravity' + d + '" class="gravityclass" data-val="true" data-val-number="The field Gravity must be a number." data-val-required="The Gravity field is required." onchange="CalculateGravity(' + d + ", " + d + ')">', i += '<option value="0" ' + ("0" == this.ddlGravity ? 'selected="selected"' : "") + ">0</option>", i += '<option value="10" ' + ("10" == this.ddlGravity ? 'selected="selected"' : "") + ">10</option>", i += '<option value="20" ' + ("20" == this.ddlGravity ? 'selected="selected"' : "") + ">20</option>", i += '<option value="30" ' + ("30" == this.ddlGravity ? 'selected="selected"' : "") + ">30</option>", i += '<option value="40" ' + ("40" == this.ddlGravity ? 'selected="selected"' : "") + ">40</option>", i += '<option value="50" ' + ("50" == this.ddlGravity ? 'selected="selected"' : "") + ">50</option>", i += '<option value="60" ' + ("60" == this.ddlGravity ? 'selected="selected"' : "") + ">60</option>", i += '<option value="70" ' + ("70" == this.ddlGravity ? 'selected="selected"' : "") + ">70</option>", i += '<option value="80" ' + ("80" == this.ddlGravity ? 'selected="selected"' : "") + ">80</option>", i += '<option value="90" ' + ("90" == this.ddlGravity ? 'selected="selected"' : "") + ">90</option>", i += '<option value="100" ' + ("100" == this.ddlGravity ? 'selected="selected"' : "") + ">100</option>", i += "</select>", i += '<span class="gravityperclass">', i += this.hdnGravityPerc + "%", i += "</span>", i += '<input type="hidden" id="hdnGravityPerc' + d + '" name="hdnGravityPerc' + d + '" class="hdnGravity" value="' + this.hdnGravityPerc + '">', i += "</div>", i += "</td>", i += '<td width="5%">', 1 != d && (i += '<input type="button" value="Delete" id="btndelete_12" name="btndelete_' + d + '" onclick="return DeleteDiv(' + d + ')" class="clsDeleteDiv del_btn">'), i += "</td>", i += "</tr>", d++
            }), $("#tblsegments").append(i), addedSegments = r.length, jscolor.installByClassName("jscolor")
        }
    }, 1e3)
}
$(document).ready(function () {

    $("#ikramlar tr:has(td)").hover(function (e) {
        $(this).css("cursor", "pointer");
        $("#ikramlar tr:has(td)").addClass('blur');
        $(this).removeClass('blur');
    },
        function (e) {
            $("#ikramlar tr:has(td)").removeClass('blur');
        });

    $.ajax({
        type: 'get',
        url: './GetMasaBilgileri',
        success: (data) => {
            data = JSON.parse(JSON.stringify(data));
            console.log(data);

            //var list = $('#ikramlar tr');
            //list.find('tr').remove();
            //list.find('th').remove();
            //list.find('div').remove();
            var rows;
            $.each(data[0].ikramlar, (i, item) => {
                rows += "<tr>" +
                    "<td>" + item.ikramName + "</td>" +
                    "</tr>";
            });
            $('#ikramlar td').html(rows);

            if (globlefuncgeneral.arrSegmentsList.length == 0) {
                var g = 1;
                for (i = 0; i < data.length; i++) {
                    globlefuncgeneral.segmentsForSpin.push(data[i].txtDisplayText);
                    for (var p = parseInt(data[i].hdnGravityPerc) / 10, h = Math.round(p), v = 0; v < h; v++) globlefuncgeneral.arrsp.push(g);
                    globlefuncgeneral.arrSegmentsList.push({
                        fillStyle: data[i].txtBackgroundColor,
                        text: data[i].txtDisplayText,
                        winResult: data[i].txtResultText.split(',').join('<br />'),
                        isCouponExist: data[i].IsCouponCode,
                        CouponCode: data[i].CouponCode
                    }),
                        g += 1;

                }
            }

        },
        error: (err) => console.log(err)
    });

    init()
}), jQuery.fn.rotate = function (e) {
    return $(this).css({
        "-webkit-transform": "rotate(" + e + "deg)",
        "-moz-transform": "rotate(" + e + "deg)",
        "-ms-transform": "rotate(" + e + "deg)",
        transform: "rotate(" + e + "deg)"
    }), $(this)
}, $(document).on("click", "#spin_button", function () {
    if (0 == globlefuncgeneral.wheelSpinning) {
        1 == globlefuncgeneral.wheelPower ? globlefuncgeneral.theWheel.animation.spins = 3 : 2 == globlefuncgeneral.wheelPower ? globlefuncgeneral.theWheel.animation.spins = 8 : 3 == globlefuncgeneral.wheelPower && (globlefuncgeneral.theWheel.animation.spins = 15);
        var e = globlefuncgeneral.arrsp.splice(globlefuncgeneral.arrsp.length * Math.random() | 0, 1)[0];
        globlefuncgeneral.theWheel.animation.stopAngle = globlefuncgeneral.theWheel.getRandomForSegment(e), 0 == globlefuncgeneral.arrsp.length && (globlefuncgeneral.arrsp = globlefuncgeneral.strarr.split("|")), document.getElementById("spin_button").className = "", globlefuncgeneral.theWheel.startAnimation(), globlefuncgeneral.wheelSpinning = !0
    }
    //setCookie("canspin", "no", globlefuncgeneral.cookidy), $("#spin_button").removeAttr("onclick"), $(".power_controls").hide()
}), $(document).on("click", ".reset_btn", function () {
    //setCookie("canspin", "yes", 1), alert("Spin reset successfully"), window.location.reload()
    window.location.reload()
}), SetJSONvalues(); 


