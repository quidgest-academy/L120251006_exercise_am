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
			name: 'FR_004',
			area: 'T_004',
			actions: {
				recalculateFormulas: 'RecalculateFormulas_Fr_004',
				updateFilesTickets: 'UpdateFilesTicketsFr_004',
				setFile: 'SetFileFr_004'
			}
		})

		/** The primary key. */
		this.ValCodt_004 = reactive(new modelFieldType.PrimaryKey({
			id: 'ValCodt_004',
			originId: 'ValCodt_004',
			area: 'T_004',
			field: 'CODT_004',
			description: '',
		}).cloneFrom(values?.ValCodt_004))
		this.stopWatchers.push(watch(() => this.ValCodt_004.value, (newValue, oldValue) => this.onUpdate('t_004.codt_004', this.ValCodt_004, newValue, oldValue)))

		/** The used foreign keys. */
		this.ValCodt_003 = reactive(new modelFieldType.ForeignKey({
			id: 'ValCodt_003',
			originId: 'ValCodt_003',
			area: 'T_004',
			field: 'F_002',
			relatedArea: 'T_003',
			description: computed(() => this.Resources.COUNTRY64133),
		}).cloneFrom(values?.ValCodt_003))
		this.stopWatchers.push(watch(() => this.ValCodt_003.value, (newValue, oldValue) => this.onUpdate('t_004.codt_003', this.ValCodt_003, newValue, oldValue)))

		/** The remaining form fields. */
		this.ValCity = reactive(new modelFieldType.String({
			id: 'ValCity',
			originId: 'ValCity',
			area: 'T_004',
			field: 'F_001',
			maxLength: 50,
			description: computed(() => this.Resources.CITY42505),
		}).cloneFrom(values?.ValCity))
		this.stopWatchers.push(watch(() => this.ValCity.value, (newValue, oldValue) => this.onUpdate('t_004.city', this.ValCity, newValue, oldValue)))

		this.TableT_003F_001 = reactive(new modelFieldType.String({
			type: 'Lookup',
			id: 'TableT_003F_001',
			originId: 'ValCountry',
			area: 'T_003',
			field: 'F_001',
			maxLength: 50,
			description: computed(() => this.Resources.COUNTRY_NAME26113),
		}).cloneFrom(values?.TableT_003F_001))
		this.stopWatchers.push(watch(() => this.TableT_003F_001.value, (newValue, oldValue) => this.onUpdate('t_003.country', this.TableT_003F_001, newValue, oldValue)))
	}

	/**
	 * Creates a clone of the current QFormFr004ViewModel instance.
	 * @returns {QFormFr004ViewModel} A new instance of QFormFr004ViewModel
	 */
	clone()
	{
		return new ViewModel(this.vueContext, { callbacks: this.externalCallbacks }, this)
	}

	static QPrimaryKeyName = 'ValCodt_004'

	get QPrimaryKey() { return this.ValCodt_004.value }
	set QPrimaryKey(value) { this.ValCodt_004.updateValue(value) }
}
