//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor v1.3.0.12
//     Source:                    https://github.com/msawczyn/EFDesigner
//     Visual Studio Marketplace: https://marketplace.visualstudio.com/items?itemName=michaelsawczyn.EFDesigner
//     Documentation:             https://msawczyn.github.io/EFDesigner/
//     License (MIT):             https://github.com/msawczyn/EFDesigner/blob/master/LICENSE
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace MyEntityClasses.Entities
{
   public partial class CategoryMovie
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected CategoryMovie()
      {
         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="_movies0"></param>
      /// <param name="_categories1"></param>
      public CategoryMovie(global::MyEntityClasses.Entities.Movies _movies0, global::MyEntityClasses.Entities.Categories _categories1)
      {
         if (_movies0 == null) throw new ArgumentNullException(nameof(_movies0));
         _movies0.CategoryMovie.Add(this);

         if (_categories1 == null) throw new ArgumentNullException(nameof(_categories1));
         _categories1.CategoryMovie.Add(this);


         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="_movies0"></param>
      /// <param name="_categories1"></param>
      public static CategoryMovie Create(global::MyEntityClasses.Entities.Movies _movies0, global::MyEntityClasses.Entities.Categories _categories1)
      {
         return new CategoryMovie(_movies0, _categories1);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Identity, Indexed, Required
      /// </summary>
      [Key]
      [Required]
      public int Id { get; protected set; }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

   }
}

