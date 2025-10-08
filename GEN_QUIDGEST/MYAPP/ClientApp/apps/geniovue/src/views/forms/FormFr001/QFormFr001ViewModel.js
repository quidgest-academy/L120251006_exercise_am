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
			name: 'FR_001',
			area: 'T_001',
			actions: {
				recalculateFormulas: 'RecalculateFormulas_Fr_001',
				updateFilesTickets: 'UpdateFilesTicketsFr_001',
				setFile: 'SetFileFr_001'
			}
		})

		/** The primary key. */
		this.ValCodt_001 = reactive(new modelFieldType.PrimaryKey({
			id: 'ValCodt_001',
			originId: 'ValCodt_001',
			area: 'T_001',
			field: 'CODT_001',
			description: '',
		}).cloneFrom(values?.ValCodt_001))
		this.stopWatchers.push(watch(() => this.ValCodt_001.value, (newValue, oldValue) => this.onUpdate('t_001.codt_001', this.ValCodt_001, newValue, oldValue)))

		/** The used foreign keys. */
		this.ValF_006 = reactive(new modelFieldType.ForeignKey({
			id: 'ValF_006',
			originId: 'ValF_006',
			area: 'T_001',
			field: 'F_006',
			relatedArea: 'AT_01',
			description: computed(() => this.Resources.COUNTRY_OF_ORIGIN50623),
		}).cloneFrom(values?.ValF_006))
		this.stopWatchers.push(watch(() => this.ValF_006.value, (newValue, oldValue) => this.onUpdate('t_001.f_006', this.ValF_006, newValue, oldValue)))

		this.ValF_007 = reactive(new modelFieldType.ForeignKey({
			id: 'ValF_007',
			originId: 'ValF_007',
			area: 'T_001',
			field: 'F_007',
			relatedArea: 'AT_02',
			description: computed(() => this.Resources.COUNTRY_OF_RESIDENCE24197),
		}).cloneFrom(values?.ValF_007))
		this.stopWatchers.push(watch(() => this.ValF_007.value, (newValue, oldValue) => this.onUpdate('t_001.f_007', this.ValF_007, newValue, oldValue)))

		/** The remaining form fields. */
		this.ValPropsold = reactive(new modelFieldType.Number({
			id: 'ValPropsold',
			originId: 'ValPropsold',
			area: 'T_001',
			field: 'F_008',
			maxDigits: 3,
			decimalDigits: 0,
			isFixed: true,
			description: computed(() => this.Resources.PROPERTIES_SOLD24318),
		}).cloneFrom(values?.ValPropsold))
		this.stopWatchers.push(watch(() => this.ValPropsold.value, (newValue, oldValue) => this.onUpdate('t_001.propsold', this.ValPropsold, newValue, oldValue)))

		this.ValProfit = reactive(new modelFieldType.Number({
			id: 'ValProfit',
			originId: 'ValProfit',
			area: 'T_001',
			field: 'F_009',
			maxDigits: 10,
			decimalDigits: 4,
			isFixed: true,
			description: computed(() => this.Resources.PROFITS_GENERATED31914),
		}).cloneFrom(values?.ValProfit))
		this.stopWatchers.push(watch(() => this.ValProfit.value, (newValue, oldValue) => this.onUpdate('t_001.profit', this.ValProfit, newValue, oldValue)))

		this.ValLastsale = reactive(new modelFieldType.Number({
			id: 'ValLastsale',
			originId: 'ValLastsale',
			area: 'T_001',
			field: 'F_010',
			maxDigits: 10,
			decimalDigits: 4,
			isFixed: true,
			description: computed(() => this.Resources.LAST_SALE23105),
		}).cloneFrom(values?.ValLastsale))
		this.stopWatchers.push(watch(() => this.ValLastsale.value, (newValue, oldValue) => this.onUpdate('t_001.lastsale', this.ValLastsale, newValue, oldValue)))

		this.ValPhoto = reactive(new modelFieldType.Image({
			id: 'ValPhoto',
			originId: 'ValPhoto',
			area: 'T_001',
			field: 'F_004',
			description: computed(() => this.Resources.PROFILE_PHOTO12166),
		}).cloneFrom(values?.ValPhoto))
		this.stopWatchers.push(watch(() => this.ValPhoto.value, (newValue, oldValue) => this.onUpdate('t_001.photo', this.ValPhoto, newValue, oldValue)))

		this.ValName = reactive(new modelFieldType.String({
			id: 'ValName',
			originId: 'ValName',
			area: 'T_001',
			field: 'F_001',
			maxLength: 50,
			description: computed(() => this.Resources.NAME31974),
		}).cloneFrom(values?.ValName))
		this.stopWatchers.push(watch(() => this.ValName.value, (newValue, oldValue) => this.onUpdate('t_001.name', this.ValName, newValue, oldValue)))

		this.ValEmail = reactive(new modelFieldType.String({
			id: 'ValEmail',
			originId: 'ValEmail',
			area: 'T_001',
			field: 'F_002',
			maxLength: 50,
			maskType: 'EM',
			description: computed(() => this.Resources.EMAIL25170),
		}).cloneFrom(values?.ValEmail))
		this.stopWatchers.push(watch(() => this.ValEmail.value, (newValue, oldValue) => this.onUpdate('t_001.email', this.ValEmail, newValue, oldValue)))

		this.ValDobirth = reactive(new modelFieldType.Date({
			id: 'ValDobirth',
			originId: 'ValDobirth',
			area: 'T_001',
			field: 'F_003',
			description: computed(() => this.Resources.DATE_OF_BIRTH36542),
		}).cloneFrom(values?.ValDobirth))
		this.stopWatchers.push(watch(() => this.ValDobirth.value, (newValue, oldValue) => this.onUpdate('t_001.dobirth', this.ValDobirth, newValue, oldValue)))

		this.ValTel = reactive(new modelFieldType.Number({
			id: 'ValTel',
			originId: 'ValTel',
			area: 'T_001',
			field: 'F_005',
			maxDigits: 8,
			decimalDigits: 0,
			description: computed(() => this.Resources.TELEPHONE28697),
		}).cloneFrom(values?.ValTel))
		this.stopWatchers.push(watch(() => this.ValTel.value, (newValue, oldValue) => this.onUpdate('t_001.tel', this.ValTel, newValue, oldValue)))

		this.TableAt_01F_001 = reactive(new modelFieldType.String({
			type: 'Lookup',
			id: 'TableAt_01F_001',
			originId: 'ValCountry',
			area: 'AT_01',
			field: 'F_001',
			maxLength: 50,
			description: computed(() => this.Resources.COUNTRY_NAME26113),
		}).cloneFrom(values?.TableAt_01F_001))
		this.stopWatchers.push(watch(() => this.TableAt_01F_001.value, (newValue, oldValue) => this.onUpdate('at_01.country', this.TableAt_01F_001, newValue, oldValue)))

		this.TableAt_02F_001 = reactive(new modelFieldType.String({
			type: 'Lookup',
			id: 'TableAt_02F_001',
			originId: 'ValCountry',
			area: 'AT_02',
			field: 'F_001',
			maxLength: 50,
			description: computed(() => this.Resources.COUNTRY_NAME26113),
		}).cloneFrom(values?.TableAt_02F_001))
		this.stopWatchers.push(watch(() => this.TableAt_02F_001.value, (newValue, oldValue) => this.onUpdate('at_02.country', this.TableAt_02F_001, newValue, oldValue)))
	}

	/**
	 * Creates a clone of the current QFormFr001ViewModel instance.
	 * @returns {QFormFr001ViewModel} A new instance of QFormFr001ViewModel
	 */
	clone()
	{
		return new ViewModel(this.vueContext, { callbacks: this.externalCallbacks }, this)
	}

	static QPrimaryKeyName = 'ValCodt_001'

	get QPrimaryKey() { return this.ValCodt_001.value }
	set QPrimaryKey(value) { this.ValCodt_001.updateValue(value) }
}
