'------------------------------------------------------------------------------
' <auto-generated>
'     Dieser Code wurde von einem Tool generiert.
'     Laufzeitversion:4.0.30319.42000
'
'     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
'     der Code erneut generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports AbstractionLevels.MuehlhausenentwicklungsplanRepository
Imports AbstractionLevels.MuehlhausenentwicklungsplanRepository.ObjectTypes
Imports AbstractionLevels.MuehlhausenentwicklungsplanRepository.ParameterTypes
Imports AbstractionLevels.StrassenplanRepository.ObjectTypes
Imports AbstractionLevels.StrassenplanRepository.ParameterTypes
Imports SemIOLibrary.Parameters
Imports SemIOLibrary.Parameters.BaseParameters
Imports SemIOLibrary.Parameters.BaseParameters.Numbers
Imports SemIOLibrary.Parameters.GeometryParameters
Imports SemIOLibrary.Parameters.GeometryParameters.Curves
Imports SemIOLibrary.Parameters.GeometryParameters.Points
Imports SemIOLibrary.Parameters.GeometryParameters.Solids
Imports SemIOLibrary.Parameters.GeometryParameters.Surfaces
Imports System

Namespace AbstractionLevels.MuehlhausenentwicklungsplanRepository.ParameterTypes
    
    <System.ComponentModel.Description("")>  _
    Public Enum Spurzahl
        
        <System.ComponentModel.Description("")>  _
        einspurig = 0
        
        <System.ComponentModel.Description("")>  _
        zweispurig = 1
        
        <System.ComponentModel.Description("")>  _
        dreispurig = 2
    End Enum
End Namespace

Namespace AbstractionLevels.MuehlhausenentwicklungsplanRepository.ObjectTypes
    
    <System.ComponentModel.Description("")>  _
    Public Class Parzelle
        
        Private _steigung As Number
        
        <System.ComponentModel.Description("")>  _
        Public Property Steigung() As Number
            Get
                Return Me._steigung
            End Get
            Set
                Me._steigung = value
            End Set
        End Property
        
        Private _eingangspunkt As Point
        
        <System.ComponentModel.Description("")>  _
        Public Property Eingangspunkt() As Point
            Get
                Return Me._eingangspunkt
            End Get
            Set
                Me._eingangspunkt = value
            End Set
        End Property
    End Class
    
    <System.ComponentModel.Description("")>  _
    Public Class Strasse
        
        Private _spur As Spurzahl
        
        <System.ComponentModel.Description("")>  _
        Public Property Spur() As Spurzahl
            Get
                Return Me._spur
            End Get
            Set
                Me._spur = value
            End Set
        End Property
    End Class
End Namespace

Namespace AbstractionLevels.MuehlhausenentwicklungsplanRepository
    
    <System.ComponentModel.Description("")>  _
    Public Class Muehlhausenentwicklungsplan
        
        Private _parzelleCollection As System.Collections.Generic.List(Of Parzelle)
        
        <System.ComponentModel.Description("")>  _
        Public Property ParzelleCollection() As System.Collections.Generic.List(Of Parzelle)
            Get
                Return Me._parzelleCollection
            End Get
            Set
            End Set
        End Property
        
        Private _strasseCollection As System.Collections.Generic.List(Of Strasse)
        
        <System.ComponentModel.Description("")>  _
        Public Property StrasseCollection() As System.Collections.Generic.List(Of Strasse)
            Get
                Return Me._strasseCollection
            End Get
            Set
            End Set
        End Property
    End Class
End Namespace

Namespace AbstractionLevels.StrassenplanRepository.ParameterTypes
    
    <System.ComponentModel.Description("")>  _
    Public Enum Bordsteinkante
        
        <System.ComponentModel.Description("")>  _
        niedrig = 0
        
        <System.ComponentModel.Description("")>  _
        hoch = 1
    End Enum
    
    <System.ComponentModel.Description(""),  _
     Flags()>  _
    Public Enum Activities
        
        <System.ComponentModel.Description("")>  _
        Durchgangsstrasse = 1
        
        <System.ComponentModel.Description("")>  _
        Spielstrasse = 2
    End Enum
End Namespace

Namespace AbstractionLevels.StrassenplanRepository.ObjectTypes
    
    <System.ComponentModel.Description("")>  _
    Public Class Gehweg
        
        Private _breite As Number
        
        <System.ComponentModel.Description("")>  _
        Public Property Breite() As Number
            Get
                Return Me._breite
            End Get
            Set
                Me._breite = value
            End Set
        End Property
        
        Private _benutzung As Activities
        
        <System.ComponentModel.Description("")>  _
        Public Property Benutzung() As Activities
            Get
                Return Me._benutzung
            End Get
            Set
                Me._benutzung = value
            End Set
        End Property
        
        Private _hoehe As Bordsteinkante
        
        <System.ComponentModel.Description("")>  _
        Public Property Hoehe() As Bordsteinkante
            Get
                Return Me._hoehe
            End Get
            Set
                Me._hoehe = value
            End Set
        End Property
    End Class
End Namespace

Namespace AbstractionLevels.StrassenplanRepository
    
    <System.ComponentModel.Description("")>  _
    Public Class Strassenplan
        Inherits Muehlhausenentwicklungsplan
        
        Private _gehwegCollection As System.Collections.Generic.List(Of Gehweg)
        
        <System.ComponentModel.Description("")>  _
        Public Property GehwegCollection() As System.Collections.Generic.List(Of Gehweg)
            Get
                Return Me._gehwegCollection
            End Get
            Set
            End Set
        End Property
    End Class
End Namespace
