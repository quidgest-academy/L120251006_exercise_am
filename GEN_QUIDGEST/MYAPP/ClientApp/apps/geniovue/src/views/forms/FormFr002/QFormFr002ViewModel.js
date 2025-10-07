/* eslint-disable @typescript-eslint/no-unused-vars */
import { computed, reactive, watch } from 'vue'
import _merge from 'lodash-es/merge'

import FormViewModelBase from '@/mixins/formViewModelBase.js'
import genericFunctions from '@quidgest/clientapp/utils/genericFunctions'
import modelFieldType from '@quidgest/clientapp/models/fields'

import hardcodedTexts from '@/hardcodedTexts.js'
import netAPI from '@quidgest/clientapp/network'
import qApi from '@/api/genio/quidgestFunctions.js'
import qFunctions from '@/api/genio/projectFunctions.js'
import qProjArrays from '@/api/genio/projectArrays.js'
/* eslint-enable @typescript-eslint/no-unused-vars */

/**
 * Represents a ViewModel class.
 * @extends FormViewModelBase
 */
export default class ViewModel extends FormViewModelBase
{
	/**
	 * Creates a new instance of the ViewModel.
	 * @param {object} vueContext - The Vue context
	 * @param {object} options - The options for the ViewModel
	 * @param {object} values - A ViewModel instance to copy values from
	 */
	// eslint-disable-next-line @typescript-eslint/no-unused-vars
	constructor(vueContext, options, values)
	{
		super(vueContext, options)
		// eslint-disable-next-line @typescript-eslint/no-unused-vars
		const vm = this.vueContext

		// The view model metadata
		_merge(this.modelInfo, {
			name: 'FR_002',
			area: 'T_002',
			actions: {
				recalculateFormulas: 'RecalculateFormulas_Fr_002',
				updateFilesTickets: 'UpdateFilesTicketsFr_002',
				setFile: 'SetFileFr_002'
			}
		})

		/** The primary key. */
		this.ValCodt_002 = reactive(new modelFieldType.PrimaryKey({
			id: 'ValCodt_002',
			originId: 'ValCodt_002',
			area: 'T_002',
			field: 'CODT_002',
			description: '',
		}).cloneFrom(values?.ValCodt_002))
		this.stopWatchers.push(watch(() => this.ValCodt_002.value, (newValue, oldValue) => this.onUpdate('t_002.codt_002', this.ValCodt_002, newValue, oldValue)))

		/** The hidden foreign keys. */
		this.ValCodt_001 = reactive(new modelFieldType.ForeignKey({
			id: 'ValCodt_001',
			originId: 'ValCodt_001',
			area: 'T_002',
			field: 'F_004',
			relatedArea: 'T_001',
			isFixed: true,
			description: '',
		}).cloneFrom(values?.ValCodt_001))
		this.stopWatchers.push(watch(() => this.ValCodt_001.value, (newValue, oldValue) => this.onUpdate('t_002.codt_001', this.ValCodt_001, newValue, oldValue)))

		/** The used foreign keys. */
		this.ValCodt_004 = reactive(new modelFieldType.ForeignKey({
			id: 'ValCodt_004',
			originId: 'ValCodt_004',
			area: 'T_002',
			field: 'F_005',
			relatedArea: 'T_004',
			description: '',
		}).cloneFrom(values?.ValCodt_004))
		this.stopWatchers.push(watch(() => this.ValCodt_004.value, (newValue, oldValue) => this.onUpdate('t_002.codt_004', this.ValCodt_004, newValue, oldValue)))

		/** The remaining form fields. */
		this.ValPhoto = reactive(new modelFieldType.Image({
			id: 'ValPhoto',
			originId: 'ValPhoto',
			area: 'T_002',
			field: 'F_001',
			description: computed(() => this.Resources.PROPERTY_PHOTO29666),
		}).cloneFrom(values?.ValPhoto))
		this.stopWatchers.push(watch(() => this.ValPhoto.value, (newValue, oldValue) => this.onUpdate('t_002.photo', this.ValPhoto, newValue, oldValue)))

		this.ValTitle = reactive(new modelFieldType.String({
			id: 'ValTitle',
			originId: 'ValTitle',
			area: 'T_002',
			field: 'F_002',
			maxLength: 50,
			description: computed(() => this.Resources.PROPERTY_TITLE56931),
		}).cloneFrom(values?.ValTitle))
		this.stopWatchers.push(watch(() => this.ValTitle.value, (newValue, oldValue) => this.onUpdate('t_002.title', this.ValTitle, newValue, oldValue)))

		this.ValPrice = reactive(new modelFieldType.Number({
			id: 'ValPrice',
			originId: 'ValPrice',
			area: 'T_002',
			field: 'F_003',
			maxDigits: 9,
			decimalDigits: 2,
			description: computed(() => this.Resources.PROPERTY_PRICE21441),
		}).cloneFrom(values?.ValPrice))
		this.stopWatchers.push(watch(() => this.ValPrice.value, (newValue, oldValue) => this.onUpdate('t_002.price', this.ValPrice, newValue, oldValue)))

		this.TableT_004F_001 = reactive(new modelFieldType.String({
			type: 'Lookup',
			id: 'TableT_004F_001',
			originId: 'ValCity',
			area: 'T_004',
			field: 'F_001',
			maxLength: 50,
			description: computed(() => this.Resources.CITY42505),
		}).cloneFrom(values?.TableT_004F_001))
		this.stopWatchers.push(watch(() => this.TableT_004F_001.value, (newValue, oldValue) => this.onUpdate('t_004.city', this.TableT_004F_001, newValue, oldValue)))

		this.ValYearbuilt = reactive(new modelFieldType.Number({
			id: 'ValYearbuilt',
			originId: 'ValYearbuilt',
			area: 'T_002',
			field: 'F_009',
			maxDigits: 4,
			decimalDigits: 0,
			description: computed(() => this.Resources.YEAR_BUILT55277),
		}).cloneFrom(values?.ValYearbuilt))
		this.stopWatchers.push(watch(() => this.ValYearbuilt.value, (newValue, oldValue) => this.onUpdate('t_002.yearbuilt', this.ValYearbuilt, newValue, oldValue)))

		this.ValSize = reactive(new modelFieldType.Number({
			id: 'ValSize',
			originId: 'ValSize',
			area: 'T_002',
			field: 'F_007',
			maxDigits: 6,
			decimalDigits: 3,
			description: computed(() => this.Resources.SIZE10299),
		}).cloneFrom(values?.ValSize))
		this.stopWatchers.push(watch(() => this.ValSize.value, (newValue, oldValue) => this.onUpdate('t_002.size', this.ValSize, newValue, oldValue)))

		this.ValBathnumber = reactive(new modelFieldType.Number({
			id: 'ValBathnumber',
			originId: 'ValBathnumber',
			area: 'T_002',
			field: 'F_008',
			maxDigits: 2,
			decimalDigits: 0,
			description: computed(() => this.Resources.BATHROUMS_NUMBER42941),
		}).cloneFrom(values?.ValBathnumber))
		this.stopWatchers.push(watch(() => this.ValBathnumber.value, (newValue, oldValue) => this.onUpdate('t_002.bathnumber', this.ValBathnumber, newValue, oldValue)))
	}

	/**
	 * Creates a clone of the current QFormFr002ViewModel instance.
	 * @returns {QFormFr002ViewModel} A new instance of QFormFr002ViewModel
	 */
	clone()
	{
		return new ViewModel(this.vueContext, { callbacks: this.externalCallbacks }, this)
	}

	static QPrimaryKeyName = 'ValCodt_002'

	get QPrimaryKey() { return this.ValCodt_002.value }
	set QPrimaryKey(value) { this.ValCodt_002.updateValue(value) }
}
