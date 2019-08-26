﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("QERP.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property CHECK_BOX_OFF_ICON() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("CHECK_BOX_OFF_ICON", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property CHECK_BOX_ON_ICON() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("CHECK_BOX_ON_ICON", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property CONFIGURE_ICON() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("CONFIGURE_ICON", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property DOC_ICON() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("DOC_ICON", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property FIRST_ARROW_ICON() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("FIRST_ARROW_ICON", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property LAST_ARROW_ICON() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("LAST_ARROW_ICON", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property LEFT_ARROW_ICON() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("LEFT_ARROW_ICON", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to --SQL
        '''CREATE OR REPLACE VIEW part_form_information_1 AS (
        '''    SELECT
        '''        p.prt_no,
        '''        p.prt_desc1,
        '''        p.prt_desc2,
        '''        p.prt_desc3,
        '''        pg.pgr_no,
        '''        pg.pgr_desc,
        '''        (
        '''            SELECT sup_no 
        '''            FROM part_supplier 
        '''            WHERE psp_idx = p.prt_def_sup_idx 
        '''            AND prt_id = p.prt_id
        '''        ),
        '''        (
        '''            SELECT sup_name1 
        '''            FROM supplier 
        '''            WHERE sup_no IN 
        '''            (
        '''                SELECT sup_no         ''' [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property part_form_information_1_view() As String
            Get
                Return ResourceManager.GetString("part_form_information_1_view", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to --SQL
        '''CREATE OR REPLACE VIEW part_form_information_2 AS (
        '''    SELECT
        '''        p.prt_no,
        '''        CASE
        '''            WHEN p.pca_no = 0 THEN &apos; &apos;
        '''            WHEN p.pca_no = -1 THEN &apos; &apos;
        '''        END AS pca_no,
        '''        p.prt_det_prt_no,
        '''        (
        '''            SELECT psp_part_no 
        '''            FROM part_supplier 
        '''            WHERE psp_idx = p.prt_def_sup_idx 
        '''            AND prt_id = p.prt_id
        '''        ),
        '''        p.prt_del_delay,
        '''        p.prt_upc,
        '''        p.prt_dsgn_no,
        '''        p.prt_issue_no,
        '''         [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property part_form_information_2_view() As String
            Get
                Return ResourceManager.GetString("part_form_information_2_view", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to --SQL
        '''CREATE OR REPLACE VIEW part_form_prev_next AS (
        '''    SELECT 
        '''        prt_no, 
        '''        LAG(prt_no) over (ORDER BY prt_no ASC) AS prev_prt_no,
        '''        LEAD(prt_no) over (ORDER BY prt_no ASC) AS next_prt_no
        '''    FROM part 
        '''    ORDER BY prt_no ASC
        ''');.
        '''</summary>
        Friend ReadOnly Property part_form_prev_next_view() As String
            Get
                Return ResourceManager.GetString("part_form_prev_next_view", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to --SQL
        '''CREATE OR REPLACE VIEW part_form_prices AS (
        '''    SELECT
        '''        prt_no,
        '''        pp.ppr_sort_idx,
        '''        CASE
        '''            WHEN pp.ppr_sort_idx = 1 THEN &apos;RETAIL CDN&apos;
        '''            WHEN pp.ppr_sort_idx = 2 THEN &apos;RETAIL USD&apos;
        '''            WHEN pp.ppr_sort_idx = 3 THEN &apos;RETAIL EURO&apos;
        '''            WHEN pp.ppr_sort_idx = 4 THEN &apos;LEVEL 4&apos;
        '''            WHEN pp.ppr_sort_idx = 5 THEN &apos;LEVEL 5&apos;
        '''        END AS price_name,
        '''        pp.ppr_price,
        '''        CASE
        '''            WHEN pp.ppr_price &lt;&gt; 0 AND ps.sup_no &lt; [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property part_form_prices_view() As String
            Get
                Return ResourceManager.GetString("part_form_prices_view", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to --SQL
        '''CREATE OR REPLACE VIEW part_listing_form AS (
        '''    SELECT 
        '''        p.prt_no,
        '''        p.prt_desc1,
        '''        p.prt_desc2,
        '''        p.prt_desc3,
        '''        p.prt_sort,
        '''        p.prt_type,
        '''        pg.pgr_no,
        '''        p.prt_upc,
        '''        p.prt_location,
        '''        p.prt_idx1_1,
        '''        p.prt_idx1_2,
        '''        p.prt_idx1_3,
        '''        p.prt_idx1_4,
        '''        p.prt_idx1_5,
        '''        p.prt_idx2_1,
        '''        p.prt_idx2_2,
        '''        p.prt_idx2_3,
        '''        p.prt_idx2_4,
        '''        p.prt_idx2_5,
        '''        p.prt_idx3_1,
        '''        p.prt_idx3_2 [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property part_listing_form_view() As String
            Get
                Return ResourceManager.GetString("part_listing_form_view", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property QUATRO_LOGO() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("QUATRO_LOGO", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property RIGHT_ARROW_ICON() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("RIGHT_ARROW_ICON", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property SEARCH_ICON() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SEARCH_ICON", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
