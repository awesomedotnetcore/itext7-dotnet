/*

This file is part of the iText (R) project.
Copyright (c) 1998-2017 iText Group NV
Authors: Bruno Lowagie, Paulo Soares, et al.

This program is free software; you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License version 3
as published by the Free Software Foundation with the addition of the
following permission added to Section 15 as permitted in Section 7(a):
FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY
ITEXT GROUP. ITEXT GROUP DISCLAIMS THE WARRANTY OF NON INFRINGEMENT
OF THIRD PARTY RIGHTS

This program is distributed in the hope that it will be useful, but
WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
or FITNESS FOR A PARTICULAR PURPOSE.
See the GNU Affero General Public License for more details.
You should have received a copy of the GNU Affero General Public License
along with this program; if not, see http://www.gnu.org/licenses or write to
the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
Boston, MA, 02110-1301 USA, or download the license from the following URL:
http://itextpdf.com/terms-of-use/

The interactive user interfaces in modified source and object code versions
of this program must display Appropriate Legal Notices, as required under
Section 5 of the GNU Affero General Public License.

In accordance with Section 7(b) of the GNU Affero General Public License,
a covered work must retain the producer line in every PDF that is created
or manipulated using iText.

You can be released from the requirements of the license by purchasing
a commercial license. Buying such a license is mandatory as soon as you
develop commercial activities involving the iText software without
disclosing the source code of your own applications.
These activities include: offering paid services to customers as an ASP,
serving PDFs on the fly in a web application, shipping iText with a closed
source product.

For more information, please contact iText Software Corp. at this
address: sales@itextpdf.com
*/
using System;

namespace iText.IO {
    /// <summary>Class containing constants to be used in logging.</summary>
    public sealed class LogMessageConstant {
        public const String ACTION_WAS_SET_TO_LINK_ANNOTATION_WITH_DESTINATION = "Action was set for a link annotation containing destination. The old destination will be cleared.";

        public const String ATTEMPT_TO_MOVE_TO_FLUSHED_PARENT = "An attempt is made to move the tag tree pointer to the tag parent which has been already flushed. Tag tree pointer is moved to the root tag instead.";

        public const String CANNOT_RESOLVE_ROLE_IN_NAMESPACE_TOO_MUCH_TRANSITIVE_MAPPINGS = "Cannot resolve \"{0}\" role in {1} namespace mapping to standard role, because of the too much transitive mappings.";

        public const String CANNOT_RESOLVE_ROLE_TOO_MUCH_TRANSITIVE_MAPPINGS = "Cannot resolve \"{0}\" role mapping to standard role, because of the too much transitive mappings.";

        public const String CLIP_ELEMENT = "Element content was clipped because some height properties are set.";

        public const String CREATED_ROOT_TAG_HAS_MAPPING = "Created root tag has role mapping: \"/Document\" role{0} is mapped{1}. Resulting tag structure might have invalid root tag.";

        public const String COLOR_NOT_FOUND = "Color \"{0}\" not found.";

        public const String COLOR_NOT_PARSED = "Color \"{0}\" was not parsed. It has invalid value. Defaulting to black color.";

        public const String COLORANT_INTENSITIES_INVALID = "Some of colorant intensities are invalid: they are bigger than 1 or less than 0. We will force them to become 1 or 0 respectively.";

        public const String COULD_NOT_FIND_GLYPH_WITH_CODE = "Could not find glyph with the following code: {0}";

        public const String DESTINATION_NOT_PERMITTED_WHEN_ACTION_IS_SET = "Destinations are not permitted for link annotations that already have actions. The old action will be removed.";

        public const String DOCUMENT_ALREADY_HAS_FIELD = "The document already has field {0}. Annotations of the fields with this name will be added to the existing one as children. If you want to have separate fields, please, rename them manually before copying.";

        public const String DOCUMENT_SERIALIZATION_EXCEPTION_RAISED = "Unhandled exception while serialization";

        public const String DIRECTONLY_OBJECT_CANNOT_BE_INDIRECT = "DirectOnly object cannot be indirect";

        public const String DOCFONT_HAS_ILLEGAL_DIFFERENCES = "Document Font has illegal differences array. Entry {0} references a glyph ID over 255 and will be ignored.";

        public const String ELEMENT_DOES_NOT_FIT_AREA = "Element does not fit current area. {0}";

        public const String ELEMENT_WAS_FORCE_PLACED_KEEP_WITH_NEXT_WILL_BE_IGNORED = "Element was placed in a forced way. Keep with next property will be ignored";

        public const String ENCOUNTERED_INVALID_MCR = "Corrupted tag structure: encountered invalid marked content reference - it doesn't refer to any page or any mcid. This content reference will be ignored.";

        public const String ENCRYPTION_ENTRIES_P_AND_ENCRYPT_METADATA_NOT_CORRESPOND_PERMS_ENTRY = "Encryption dictionary entries P and EncryptMetadata have value that does not correspond to encrypted values in Perms key.";

        public const String EXCEPTION_WHILE_UPDATING_XMPMETADATA = "Exception while updating XmpMetadata";

        public const String EXCEPTION_WHILE_CREATING_DEFAULT_FONT = "Exception while creating default font (Helvetica, WinAnsi)";

        public const String EXISTING_TAG_STRUCTURE_ROOT_IS_NOT_STANDARD = "Existing tag structure of the document has a root of \"{0}\" role in \"{1}\" namespace that is not mapped to the standard role.";

        public const String FEATURE_IS_DEPRECATED = "{0} is deprecated for the {1} and higher versions. It is highly recommended not to use it.";

        public const String FONT_HAS_INVALID_GLYPH = "Font {0} has invalid glyph: {1}";

        public const String FORBID_RELEASE_IS_SET = "ForbidRelease flag is set and release is called. Releasing will not be performed.";

        public const String IMAGE_HAS_AMBIGUOUS_SCALE = "The image cannot be auto scaled and scaled by a certain parameter simultaneously";

        public const String IMAGE_HAS_JBIG2DECODE_FILTER = "Image cannot be inline if it has JBIG2Decode filter. It will be added as an ImageXObject";

        public const String IMAGE_HAS_MASK = "Image cannot be inline if it has a Mask";

        public const String IMAGE_HAS_JPXDECODE_FILTER = "Image cannot be inline if it has JPXDecode filter. It will be added as an ImageXObject";

        public const String IMAGE_SIZE_CANNOT_BE_MORE_4KB = "Inline image size cannot be more than 4KB. It will be added as an ImageXObject";

        public const String INCORRECT_PAGEROTATION = "Encounterd a page rotation that was not a multiple of 90°/ (Pi/2) when generating default appearances for form fields";

        public const String INPUT_STREAM_CONTENT_IS_LOST_ON_PDFSTREAM_SERIALIZATION = "PdfStream contains not null input stream. It's content will be lost in serialized object.";

        public const String INVALID_INDIRECT_REFERENCE = "Invalid indirect reference {0} {1} R";

        public const String INVALID_KEY_VALUE_KEY_0_HAS_NULL_VALUE = "Invalid key value: key {0} has null value.";

        public const String LAST_ROW_IS_NOT_COMPLETE = "Last row is not completed. Table bottom border may collapse as you do not expect it";

        public const String CALCULATE_HASHCODE_FOR_MODIFIED_PDFNUMBER = "Calculate hashcode for modified PdfNumber.";

        public const String MAKE_COPY_OF_CATALOG_DICTIONARY_IS_FORBIDDEN = "Make copy of Catalog dictionary is forbidden.";

        public const String MAPPING_IN_NAMESPACE_OVERWRITTEN = "Existing mapping for {0} in {1} namespace was overwritten.";

        public const String MAPPING_IN_STRUCT_ROOT_OVERWRITTEN = "Existing mapping for {0} in structure tree root role map was {1} and it was overwritten with {2}.";

        public const String NAME_ALREADY_EXISTS_IN_THE_NAME_TREE = "Name \"{0}\" already exists in the name tree; old value will be replaced by the new one.";

        public const String NOT_TAGGED_PAGES_IN_TAGGED_DOCUMENT = "Not tagged pages are copied to the tagged document. Destination document now may contain not tagged content.";

        public const String PDF_READER_CLOSING_FAILED = "PdfReader closing failed due to the error occurred!";

        public const String PDF_WRITER_CLOSING_FAILED = "PdfWriter closing failed due to the error occurred!";

        public const String POPUP_ENTRY_IS_NOT_POPUP_ANNOTATION = "Popup entry in the markup annotations refers not to the annotation with Popup subtype.";

        public const String OCCUPIED_AREA_HAS_NOT_BEEN_INITIALIZED = "Occupied area hasn't been initialized. Drawing won't be performed";

        public const String OCSP_STATUS_IS_REVOKED = "OCSP status is revoked.";

        public const String OCSP_STATUS_IS_UNKNOWN = "OCSP status is unknown.";

        public const String ONE_OF_GROUPED_SOURCES_CLOSING_FAILED = "Closing of one of the grouped sources failed.";

        public const String ONLY_ONE_OF_ARTBOX_OR_TRIMBOX_CAN_EXIST_IN_THE_PAGE = "Only one of artbox or trimbox can exist on the page. The trimbox will be deleted";

        public const String PDF_OBJECT_FLUSHING_NOT_PERFORMED = "PdfObject flushing is not performed: PdfDocument is opened in append mode and the object is not marked as modified ( see PdfObject#setModified() ).";

        public const String RECTANGLE_HAS_NEGATIVE_SIZE = "The {0} rectangle has negative size. It will not be displayed.";

        public const String RECTANGLE_HAS_NEGATIVE_OR_ZERO_SIZES = "The {0} rectangle has negative or zero sizes. It will not be displayed.";

        public const String REGISTERING_DIRECTORY = "Registering directory";

        public const String REMOVING_PAGE_HAS_ALREADY_BEEN_FLUSHED = "The removing page has already been flushed.";

        public const String RENDERER_WAS_NOT_ABLE_TO_PROCESS_KEEP_WITH_NEXT = "The renderer was not able to process keep with next property properly";

        public const String ROLE_MAPPING_FROM_SOURCE_IS_NOT_COPIED = "Role mapping \"{0}\" from source document is not copied. Destination document already has \"{1}\" mapping.";

        public const String ROTATION_WAS_NOT_CORRECTLY_PROCESSED_FOR_RENDERER = "Rotation was not correctly processed for {0}";

        public const String SOURCE_DOCUMENT_HAS_ACROFORM_DICTIONARY = "Source document has AcroForm dictionary. The pages you are going to copy may have FormFields, but they will not be copied, because you have not used any IPdfPageExtraCopier";

        public const String START_MARKER_MISSING_IN_PFB_FILE = "Start marker is missing in the pfb file";

        public const String SUM_OF_TABLE_COLUMNS_IS_GREATER_THAN_100 = "Sum of table columns is greater than 100%.";

        public const String TABLE_WIDTH_IS_MORE_THAN_EXPECTED_DUE_TO_MIN_WIDTH = "Table width is more than expected due to min width of cell(s).";

        public const String TAG_STRUCTURE_CONTEXT_WILL_BE_REINITIALIZED_ON_SERIALIZATION = "Tag structure context is not null and will be reinitialized in the copy of document. The copy may lose some data";

        public const String TAG_STRUCTURE_INIT_FAILED = "Tag structure initialization failed, tag structure is ignored, it might be corrupted.";

        public const String VERSION_INCOMPATIBILITY_FOR_DICTIONARY_ENTRY = "\"{0}\" entry in the \"{1}\" dictionary is a {2} and higher version feature. It is meaningless for the current {3} version.";

        public const String UNEXPECTED_BEHAVIOUR_DURING_TABLE_ROW_COLLAPSING = "Unexpected behaviour during table row collapsing. Calculated rowspan was less then 1.";

        public const String UNKNOWN_CMAP = "Unknown CMap {0}";

        public const String UNKNOWN_COLOR_FORMAT_MUST_BE_RGB_OR_RRGGBB = "Unknown color format: must be rgb or rrggbb.";

        public const String UNKNOWN_ERROR_WHILE_PROCESSING_CMAP = "Unknown error while processing CMap.";

        public const String TOUNICODE_CMAP_MORE_THAN_2_BYTES_NOT_SUPPORTED = "ToUnicode CMap more than 2 bytes not supported.";

        public const String WRITER_ENCRYPTION_IS_IGNORED_APPEND = "Writer encryption will be ignored, because append mode is used. Document will preserve the original encryption (or will stay unencrypted)";

        public const String WRITER_ENCRYPTION_IS_IGNORED_PRESERVE = "Writer encryption will be ignored, because preservation of encryption is enabled. Document will preserve the original encryption (or will stay unencrypted)";

        public const String XREF_ERROR = "Error occurred while reading cross reference table. Cross reference table will be rebuilt.";
    }
}
