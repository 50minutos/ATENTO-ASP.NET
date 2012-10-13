﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("DbModel", "FK_FILHO_PESSOA", "PESSOA", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(_004_WCFDados.Pessoa), "FILHO", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(_004_WCFDados.Filho), true)]

#endregion

namespace _004_WCFDados
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DbEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DbEntities object using the connection string found in the 'DbEntities' section of the application configuration file.
        /// </summary>
        public DbEntities() : base("name=DbEntities", "DbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DbEntities object.
        /// </summary>
        public DbEntities(string connectionString) : base(connectionString, "DbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DbEntities object.
        /// </summary>
        public DbEntities(EntityConnection connection) : base(connection, "DbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Filho> Filhos
        {
            get
            {
                if ((_Filhos == null))
                {
                    _Filhos = base.CreateObjectSet<Filho>("Filhos");
                }
                return _Filhos;
            }
        }
        private ObjectSet<Filho> _Filhos;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Pessoa> Pessoas
        {
            get
            {
                if ((_Pessoas == null))
                {
                    _Pessoas = base.CreateObjectSet<Pessoa>("Pessoas");
                }
                return _Pessoas;
            }
        }
        private ObjectSet<Pessoa> _Pessoas;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Filhos EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToFilhos(Filho filho)
        {
            base.AddObject("Filhos", filho);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Pessoas EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPessoas(Pessoa pessoa)
        {
            base.AddObject("Pessoas", pessoa);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DbModel", Name="Filho")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Filho : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Filho object.
        /// </summary>
        /// <param name="codigo">Initial value of the Codigo property.</param>
        public static Filho CreateFilho(global::System.Int32 codigo)
        {
            Filho filho = new Filho();
            filho.Codigo = codigo;
            return filho;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Codigo
        {
            get
            {
                return _Codigo;
            }
            set
            {
                if (_Codigo != value)
                {
                    OnCodigoChanging(value);
                    ReportPropertyChanging("Codigo");
                    _Codigo = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Codigo");
                    OnCodigoChanged();
                }
            }
        }
        private global::System.Int32 _Codigo;
        partial void OnCodigoChanging(global::System.Int32 value);
        partial void OnCodigoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Nome
        {
            get
            {
                return _Nome;
            }
            set
            {
                OnNomeChanging(value);
                ReportPropertyChanging("Nome");
                _Nome = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Nome");
                OnNomeChanged();
            }
        }
        private global::System.String _Nome;
        partial void OnNomeChanging(global::System.String value);
        partial void OnNomeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> CodigoPessoa
        {
            get
            {
                return _CodigoPessoa;
            }
            set
            {
                OnCodigoPessoaChanging(value);
                ReportPropertyChanging("CodigoPessoa");
                _CodigoPessoa = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CodigoPessoa");
                OnCodigoPessoaChanged();
            }
        }
        private Nullable<global::System.Int32> _CodigoPessoa;
        partial void OnCodigoPessoaChanging(Nullable<global::System.Int32> value);
        partial void OnCodigoPessoaChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DbModel", "FK_FILHO_PESSOA", "PESSOA")]
        public Pessoa PESSOA
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Pessoa>("DbModel.FK_FILHO_PESSOA", "PESSOA").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Pessoa>("DbModel.FK_FILHO_PESSOA", "PESSOA").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Pessoa> PESSOAReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Pessoa>("DbModel.FK_FILHO_PESSOA", "PESSOA");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Pessoa>("DbModel.FK_FILHO_PESSOA", "PESSOA", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DbModel", Name="Pessoa")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Pessoa : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Pessoa object.
        /// </summary>
        /// <param name="codigo">Initial value of the Codigo property.</param>
        public static Pessoa CreatePessoa(global::System.Int32 codigo)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Codigo = codigo;
            return pessoa;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Codigo
        {
            get
            {
                return _Codigo;
            }
            set
            {
                if (_Codigo != value)
                {
                    OnCodigoChanging(value);
                    ReportPropertyChanging("Codigo");
                    _Codigo = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Codigo");
                    OnCodigoChanged();
                }
            }
        }
        private global::System.Int32 _Codigo;
        partial void OnCodigoChanging(global::System.Int32 value);
        partial void OnCodigoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Nome
        {
            get
            {
                return _Nome;
            }
            set
            {
                OnNomeChanging(value);
                ReportPropertyChanging("Nome");
                _Nome = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Nome");
                OnNomeChanged();
            }
        }
        private global::System.String _Nome;
        partial void OnNomeChanging(global::System.String value);
        partial void OnNomeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Sexo
        {
            get
            {
                return _Sexo;
            }
            set
            {
                OnSexoChanging(value);
                ReportPropertyChanging("Sexo");
                _Sexo = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Sexo");
                OnSexoChanged();
            }
        }
        private global::System.String _Sexo;
        partial void OnSexoChanging(global::System.String value);
        partial void OnSexoChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DbModel", "FK_FILHO_PESSOA", "FILHO")]
        public EntityCollection<Filho> FILHO
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Filho>("DbModel.FK_FILHO_PESSOA", "FILHO");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Filho>("DbModel.FK_FILHO_PESSOA", "FILHO", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
