#pragma checksum "C:\Users\Murad\source\repos\MultiShop\Views\Clothes\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e602f6616ae60cf69995d60b3e3447b197d6ee08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clothes_Detail), @"mvc.1.0.view", @"/Views/Clothes/Detail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Murad\source\repos\MultiShop\Views\_ViewImports.cshtml"
using MultiShop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Murad\source\repos\MultiShop\Views\_ViewImports.cshtml"
using MultiShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e602f6616ae60cf69995d60b3e3447b197d6ee08", @"/Views/Clothes/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3db805bf3fdf4c4852a6459df90449d8b776bf7", @"/Views/_ViewImports.cshtml")]
    public class Views_Clothes_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Breadcrumb Start -->
<div class=""container-fluid"">
    <div class=""row px-xl-5"">
        <div class=""col-12"">
            <nav class=""breadcrumb bg-light mb-30"">
                <a class=""breadcrumb-item text-dark"" href=""#"">Home</a>
                <a class=""breadcrumb-item text-dark"" href=""#"">Shop</a>
                <span class=""breadcrumb-item active"">Shop Detail</span>
            </nav>
        </div>
    </div>
</div>
<!-- Breadcrumb End -->
<!-- Shop Detail Start -->
<div class=""container-fluid pb-5"">
    <div class=""row px-xl-5"">
        <div class=""col-lg-5 mb-30"">
            <div id=""product-carousel"" class=""carousel slide"" data-ride=""carousel"">
                <div class=""carousel-inner bg-light"">
                    <div class=""carousel-item active"">
                        <img class=""w-100 h-100"" src=""img/product-1.jpg"" alt=""Image"">
                    </div>
                    <div class=""carousel-item"">
                        <img class=""w-100 h-100"" src=""img/pro");
            WriteLiteral(@"duct-2.jpg"" alt=""Image"">
                    </div>
                    <div class=""carousel-item"">
                        <img class=""w-100 h-100"" src=""img/product-3.jpg"" alt=""Image"">
                    </div>
                    <div class=""carousel-item"">
                        <img class=""w-100 h-100"" src=""img/product-4.jpg"" alt=""Image"">
                    </div>
                </div>
                <a class=""carousel-control-prev"" href=""#product-carousel"" data-slide=""prev"">
                    <i class=""fa fa-2x fa-angle-left text-dark""></i>
                </a>
                <a class=""carousel-control-next"" href=""#product-carousel"" data-slide=""next"">
                    <i class=""fa fa-2x fa-angle-right text-dark""></i>
                </a>
            </div>
        </div>

        <div class=""col-lg-7 h-auto mb-30"">
            <div class=""h-100 bg-light p-30"">
                <h3>Product Name Goes Here</h3>
                <div class=""d-flex mb-3"">
                    <di");
            WriteLiteral(@"v class=""text-primary mr-2"">
                        <small class=""fas fa-star""></small>
                        <small class=""fas fa-star""></small>
                        <small class=""fas fa-star""></small>
                        <small class=""fas fa-star-half-alt""></small>
                        <small class=""far fa-star""></small>
                    </div>
                    <small class=""pt-1"">(99 Reviews)</small>
                </div>
                <h3 class=""font-weight-semi-bold mb-4"">$150.00</h3>
                <p class=""mb-4"">
                    Volup erat ipsum diam elitr rebum et dolor. Est nonumy elitr erat diam stet sit
                    clita ea. Sanc ipsum et, labore clita lorem magna duo dolor no sea
                    Nonumy
                </p>
                <div class=""d-flex mb-3"">
                    <strong class=""text-dark mr-3"">Sizes:</strong>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e602f6616ae60cf69995d60b3e3447b197d6ee086340", async() => {
                WriteLiteral(@"
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" class=""custom-control-input"" id=""size-1"" name=""size"">
                            <label class=""custom-control-label"" for=""size-1"">XS</label>
                        </div>
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" class=""custom-control-input"" id=""size-2"" name=""size"">
                            <label class=""custom-control-label"" for=""size-2"">S</label>
                        </div>
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" class=""custom-control-input"" id=""size-3"" name=""size"">
                            <label class=""custom-control-label"" for=""size-3"">M</label>
                        </div>
                        <div class=""custom-control custom-radio custom-control-inline");
                WriteLiteral(@""">
                            <input type=""radio"" class=""custom-control-input"" id=""size-4"" name=""size"">
                            <label class=""custom-control-label"" for=""size-4"">L</label>
                        </div>
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" class=""custom-control-input"" id=""size-5"" name=""size"">
                            <label class=""custom-control-label"" for=""size-5"">XL</label>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-flex mb-4\">\r\n                    <strong class=\"text-dark mr-3\">Colors:</strong>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e602f6616ae60cf69995d60b3e3447b197d6ee089424", async() => {
                WriteLiteral(@"
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" class=""custom-control-input"" id=""color-1"" name=""color"">
                            <label class=""custom-control-label"" for=""color-1"">Black</label>
                        </div>
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" class=""custom-control-input"" id=""color-2"" name=""color"">
                            <label class=""custom-control-label"" for=""color-2"">White</label>
                        </div>
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" class=""custom-control-input"" id=""color-3"" name=""color"">
                            <label class=""custom-control-label"" for=""color-3"">Red</label>
                        </div>
                        <div class=""custom-control custom-radio cus");
                WriteLiteral(@"tom-control-inline"">
                            <input type=""radio"" class=""custom-control-input"" id=""color-4"" name=""color"">
                            <label class=""custom-control-label"" for=""color-4"">Blue</label>
                        </div>
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" class=""custom-control-input"" id=""color-5"" name=""color"">
                            <label class=""custom-control-label"" for=""color-5"">Green</label>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""d-flex align-items-center mb-4 pt-2"">
                    <div class=""input-group quantity mr-3"" style=""width: 130px;"">
                        <div class=""input-group-btn"">
                            <button class=""btn btn-primary btn-minus"">
                                <i class=""fa fa-minus""></i>
                            </button>
                        </div>
                        <input type=""text"" class=""form-control bg-secondary border-0 text-center"" value=""1"">
                        <div class=""input-group-btn"">
                            <button class=""btn btn-primary btn-plus"">
                                <i class=""fa fa-plus""></i>
                            </button>
                        </div>
                    </div>
                    <button class=""btn btn-primary px-3"">
                        <i class=""fa fa-shopping-cart mr-1""></i> Add To
                        Cart
                    </button>
 ");
            WriteLiteral("               </div>\r\n                <div class=\"d-flex pt-2\">\r\n                    <strong class=\"text-dark mr-2\">Share on:</strong>\r\n                    <div class=\"d-inline-flex\">\r\n                        <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 7620, "\"", 7627, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"fab fa-facebook-f\"></i>\r\n                        </a>\r\n                        <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 7773, "\"", 7780, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"fab fa-twitter\"></i>\r\n                        </a>\r\n                        <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 7923, "\"", 7930, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"fab fa-linkedin-in\"></i>\r\n                        </a>\r\n                        <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 8077, "\"", 8084, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""fab fa-pinterest""></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row px-xl-5"">
        <div class=""col"">
            <div class=""bg-light p-30"">
                <div class=""nav nav-tabs mb-4"">
                    <a class=""nav-item nav-link text-dark active"" data-toggle=""tab"" href=""#tab-pane-1"">Description</a>
                    <a class=""nav-item nav-link text-dark"" data-toggle=""tab"" href=""#tab-pane-2"">Information</a>
                    <a class=""nav-item nav-link text-dark"" data-toggle=""tab"" href=""#tab-pane-3"">Reviews (0)</a>
                </div>
                <div class=""tab-content"">
                    <div class=""tab-pane fade show active"" id=""tab-pane-1"">
                        <h4 class=""mb-3"">Product Description</h4>
                        <p>Eos no lorem eirmod diam diam, eos elitr et gubergren diam sea. Consetetur vero aliquyam invidunt");
            WriteLiteral(@" duo dolores et duo sit. Vero diam ea vero et dolore rebum, dolor rebum eirmod consetetur invidunt sed sed et, lorem duo et eos elitr, sadipscing kasd ipsum rebum diam. Dolore diam stet rebum sed tempor kasd eirmod. Takimata kasd ipsum accusam sadipscing, eos dolores sit no ut diam consetetur duo justo est, sit sanctus diam tempor aliquyam eirmod nonumy rebum dolor accusam, ipsum kasd eos consetetur at sit rebum, diam kasd invidunt tempor lorem, ipsum lorem elitr sanctus eirmod takimata dolor ea invidunt.</p>
                        <p>Dolore magna est eirmod sanctus dolor, amet diam et eirmod et ipsum. Amet dolore tempor consetetur sed lorem dolor sit lorem tempor. Gubergren amet amet labore sadipscing clita clita diam clita. Sea amet et sed ipsum lorem elitr et, amet et labore voluptua sit rebum. Ea erat sed et diam takimata sed justo. Magna takimata justo et amet magna et.</p>
                    </div>
                    <div class=""tab-pane fade"" id=""tab-pane-2"">
                        <h4 class=""m");
            WriteLiteral(@"b-3"">Additional Information</h4>
                        <p>Eos no lorem eirmod diam diam, eos elitr et gubergren diam sea. Consetetur vero aliquyam invidunt duo dolores et duo sit. Vero diam ea vero et dolore rebum, dolor rebum eirmod consetetur invidunt sed sed et, lorem duo et eos elitr, sadipscing kasd ipsum rebum diam. Dolore diam stet rebum sed tempor kasd eirmod. Takimata kasd ipsum accusam sadipscing, eos dolores sit no ut diam consetetur duo justo est, sit sanctus diam tempor aliquyam eirmod nonumy rebum dolor accusam, ipsum kasd eos consetetur at sit rebum, diam kasd invidunt tempor lorem, ipsum lorem elitr sanctus eirmod takimata dolor ea invidunt.</p>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <ul class=""list-group list-group-flush"">
                                    <li class=""list-group-item px-0"">
                                        Sit erat duo lorem duo ea consetetur, et eirmod takimata.
           ");
            WriteLiteral(@"                         </li>
                                    <li class=""list-group-item px-0"">
                                        Amet kasd gubergren sit sanctus et lorem eos sadipscing at.
                                    </li>
                                    <li class=""list-group-item px-0"">
                                        Duo amet accusam eirmod nonumy stet et et stet eirmod.
                                    </li>
                                    <li class=""list-group-item px-0"">
                                        Takimata ea clita labore amet ipsum erat justo voluptua. Nonumy.
                                    </li>
                                </ul>
                            </div>
                            <div class=""col-md-6"">
                                <ul class=""list-group list-group-flush"">
                                    <li class=""list-group-item px-0"">
                                        Sit erat duo lorem duo ea consetetu");
            WriteLiteral(@"r, et eirmod takimata.
                                    </li>
                                    <li class=""list-group-item px-0"">
                                        Amet kasd gubergren sit sanctus et lorem eos sadipscing at.
                                    </li>
                                    <li class=""list-group-item px-0"">
                                        Duo amet accusam eirmod nonumy stet et et stet eirmod.
                                    </li>
                                    <li class=""list-group-item px-0"">
                                        Takimata ea clita labore amet ipsum erat justo voluptua. Nonumy.
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class=""tab-pane fade"" id=""tab-pane-3"">
                        <div class=""row"">
                            <div class=""col-md-6"">
                 ");
            WriteLiteral(@"               <h4 class=""mb-4"">1 review for ""Product Name""</h4>
                                <div class=""media mb-4"">
                                    <img src=""img/user.jpg"" alt=""Image"" class=""img-fluid mr-3 mt-1"" style=""width: 45px;"">
                                    <div class=""media-body"">
                                        <h6>John Doe<small> - <i>01 Jan 2045</i></small></h6>
                                        <div class=""text-primary mb-2"">
                                            <i class=""fas fa-star""></i>
                                            <i class=""fas fa-star""></i>
                                            <i class=""fas fa-star""></i>
                                            <i class=""fas fa-star-half-alt""></i>
                                            <i class=""far fa-star""></i>
                                        </div>
                                        <p>Diam amet duo labore stet elitr ea clita ipsum, tempor labore accusam ipsum et no ");
            WriteLiteral(@"at. Kasd diam tempor rebum magna dolores sed sed eirmod ipsum.</p>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <h4 class=""mb-4"">Leave a review</h4>
                                <small>Your email address will not be published. Required fields are marked *</small>
                                <div class=""d-flex my-3"">
                                    <p class=""mb-0 mr-2"">Your Rating * :</p>
                                    <div class=""text-primary"">
                                        <i class=""far fa-star""></i>
                                        <i class=""far fa-star""></i>
                                        <i class=""far fa-star""></i>
                                        <i class=""far fa-star""></i>
                                        <i class=""far fa-star""></i>
                                    </div>
     ");
            WriteLiteral("                           </div>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e602f6616ae60cf69995d60b3e3447b197d6ee0822311", async() => {
                WriteLiteral(@"
                                    <div class=""form-group"">
                                        <label for=""message"">Your Review *</label>
                                        <textarea id=""message"" cols=""30"" rows=""5"" class=""form-control""></textarea>
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""name"">Your Name *</label>
                                        <input type=""text"" class=""form-control"" id=""name"">
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""email"">Your Email *</label>
                                        <input type=""email"" class=""form-control"" id=""email"">
                                    </div>
                                    <div class=""form-group mb-0"">
                                        <input type=""submit"" value=""Leave Your Review"" clas");
                WriteLiteral("s=\"btn btn-primary px-3\">\r\n                                    </div>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Shop Detail End -->
<!-- Products Start -->
<div class=""container-fluid py-5"">
    <h2 class=""section-title position-relative text-uppercase mx-xl-5 mb-4""><span class=""bg-secondary pr-3"">You May Also Like</span></h2>
    <div class=""row px-xl-5"">
        <div class=""col"">
            <div class=""owl-carousel related-carousel"">
                <div class=""product-item bg-light"">
                    <div class=""product-img position-relative overflow-hidden"">
                        <img class=""img-fluid w-100"" src=""img/product-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 17189, "\"", 17195, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"product-action\">\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 17323, "\"", 17330, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-shopping-cart\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 17443, "\"", 17450, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-heart\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 17556, "\"", 17563, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-sync-alt\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 17671, "\"", 17678, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-search\"></i></a>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"text-center py-4\">\r\n                        <a class=\"h6 text-decoration-none text-truncate\"");
            BeginWriteAttribute("href", " href=\"", 17898, "\"", 17905, 0);
            EndWriteAttribute();
            WriteLiteral(@">Product Name Goes Here</a>
                        <div class=""d-flex align-items-center justify-content-center mt-2"">
                            <h5>$123.00</h5><h6 class=""text-muted ml-2""><del>$123.00</del></h6>
                        </div>
                        <div class=""d-flex align-items-center justify-content-center mb-1"">
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small>(99)</small>
                        </div>
                    </div>
                </div>
                <div class=""product-item bg-light"">
                    <div class=""product-img position-relative overflow-hidden"">
   ");
            WriteLiteral("                     <img class=\"img-fluid w-100\" src=\"img/product-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 19003, "\"", 19009, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"product-action\">\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 19137, "\"", 19144, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-shopping-cart\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 19257, "\"", 19264, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-heart\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 19370, "\"", 19377, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-sync-alt\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 19485, "\"", 19492, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-search\"></i></a>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"text-center py-4\">\r\n                        <a class=\"h6 text-decoration-none text-truncate\"");
            BeginWriteAttribute("href", " href=\"", 19712, "\"", 19719, 0);
            EndWriteAttribute();
            WriteLiteral(@">Product Name Goes Here</a>
                        <div class=""d-flex align-items-center justify-content-center mt-2"">
                            <h5>$123.00</h5><h6 class=""text-muted ml-2""><del>$123.00</del></h6>
                        </div>
                        <div class=""d-flex align-items-center justify-content-center mb-1"">
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small>(99)</small>
                        </div>
                    </div>
                </div>
                <div class=""product-item bg-light"">
                    <div class=""product-img position-relative overflow-hidden"">
   ");
            WriteLiteral("                     <img class=\"img-fluid w-100\" src=\"img/product-3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 20817, "\"", 20823, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"product-action\">\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 20951, "\"", 20958, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-shopping-cart\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 21071, "\"", 21078, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-heart\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 21184, "\"", 21191, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-sync-alt\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 21299, "\"", 21306, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-search\"></i></a>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"text-center py-4\">\r\n                        <a class=\"h6 text-decoration-none text-truncate\"");
            BeginWriteAttribute("href", " href=\"", 21526, "\"", 21533, 0);
            EndWriteAttribute();
            WriteLiteral(@">Product Name Goes Here</a>
                        <div class=""d-flex align-items-center justify-content-center mt-2"">
                            <h5>$123.00</h5><h6 class=""text-muted ml-2""><del>$123.00</del></h6>
                        </div>
                        <div class=""d-flex align-items-center justify-content-center mb-1"">
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small>(99)</small>
                        </div>
                    </div>
                </div>
                <div class=""product-item bg-light"">
                    <div class=""product-img position-relative overflow-hidden"">
   ");
            WriteLiteral("                     <img class=\"img-fluid w-100\" src=\"img/product-4.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 22631, "\"", 22637, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"product-action\">\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 22765, "\"", 22772, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-shopping-cart\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 22885, "\"", 22892, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-heart\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 22998, "\"", 23005, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-sync-alt\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 23113, "\"", 23120, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-search\"></i></a>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"text-center py-4\">\r\n                        <a class=\"h6 text-decoration-none text-truncate\"");
            BeginWriteAttribute("href", " href=\"", 23340, "\"", 23347, 0);
            EndWriteAttribute();
            WriteLiteral(@">Product Name Goes Here</a>
                        <div class=""d-flex align-items-center justify-content-center mt-2"">
                            <h5>$123.00</h5><h6 class=""text-muted ml-2""><del>$123.00</del></h6>
                        </div>
                        <div class=""d-flex align-items-center justify-content-center mb-1"">
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small>(99)</small>
                        </div>
                    </div>
                </div>
                <div class=""product-item bg-light"">
                    <div class=""product-img position-relative overflow-hidden"">
   ");
            WriteLiteral("                     <img class=\"img-fluid w-100\" src=\"img/product-5.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 24445, "\"", 24451, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"product-action\">\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 24579, "\"", 24586, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-shopping-cart\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 24699, "\"", 24706, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-heart\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 24812, "\"", 24819, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-sync-alt\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 24927, "\"", 24934, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-search\"></i></a>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"text-center py-4\">\r\n                        <a class=\"h6 text-decoration-none text-truncate\"");
            BeginWriteAttribute("href", " href=\"", 25154, "\"", 25161, 0);
            EndWriteAttribute();
            WriteLiteral(@">Product Name Goes Here</a>
                        <div class=""d-flex align-items-center justify-content-center mt-2"">
                            <h5>$123.00</h5><h6 class=""text-muted ml-2""><del>$123.00</del></h6>
                        </div>
                        <div class=""d-flex align-items-center justify-content-center mb-1"">
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small class=""fa fa-star text-primary mr-1""></small>
                            <small>(99)</small>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Products End -->
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591